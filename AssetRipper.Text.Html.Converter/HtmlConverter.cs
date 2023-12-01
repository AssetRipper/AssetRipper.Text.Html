using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AssetRipper.Text.Html.Model;
using AssetRipper.Text.SourceGeneration;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using ModelElement = AssetRipper.Text.Html.Model.HtmlElement;

namespace AssetRipper.Text.Html.Converter;

internal static partial class HtmlConverter
{
	private static IReadOnlyDictionary<string, ModelElement> ElementDictionary { get; } = HtmlJsonLoader.Load();

	//This works perfect, except for whitespace removal. That could be improved.
	//Currently, there's a lot of `writer.Write(' ');` calls that get generated,
	//and they have to be manually removed.

	public static string Convert(string input)
	{
		// Use AngleSharp HTML parser
		HtmlParser htmlParser = new();
		IHtmlDocument document = htmlParser.ParseDocument(input);

		StringWriter stringWriter = new();
		IndentedTextWriter writer = new IndentedTextWriter(stringWriter, "\t") { NewLine = "\n" };

		foreach (IElement child in document.Children)
		{
			Write(writer, child, false);
		}

		return stringWriter.ToString();
	}

	static void Write(IndentedTextWriter writer, IElement node, bool mightHaveSignificantWhiteSpace)
	{
		if (node.ChildNodes.Length == 0)
		{
			writer.Write("new ");
		}
		else
		{
			writer.Write("using (new ");
		}

		if (ElementDictionary.TryGetValue(node.LocalName, out ModelElement? elementData))
		{
			writer.Write($"{elementData.ClassName}(writer)");
		}
		else
		{
			writer.Write($"ModelElement(writer, {ToLiteral(node.LocalName)})");
		}

		WriteAttributes(writer, node.Attributes, elementData);

		if (node.ChildNodes.Length == 0)
		{
			writer.WriteLine(".Close();");
		}
		else
		{
			writer.WriteLine(".End())");
			using (new CurlyBrackets(writer))
			{
				foreach (INode child in node.ChildNodes)
				{
					switch (child)
					{
						case IElement childElement:
							Write(writer, childElement, mightHaveSignificantWhiteSpace || elementData is null || MightHaveSignificantWhiteSpace(elementData.Name));
							break;
						case { } when child.NodeType is NodeType.Text:
							{
								string text = child.NodeValue ?? "";
								if (child == node.FirstChild)
								{
									text = text.TrimStart();
								}
								if (child == node.LastChild)
								{
									text = text.TrimEnd();
								}
								if (!mightHaveSignificantWhiteSpace)
								{
									text = WhiteSpaceRegex().Replace(text, " ");
								}
								if (!string.IsNullOrEmpty(text))
								{
									writer.Write("writer.Write(");
									writer.Write(ToLiteral(text));
									writer.WriteLine(");");
								}
							}
							break;
						default:
							throw new NotSupportedException();
					}
				}
			}
		}
	}

	static void WriteAttributes(IndentedTextWriter writer, INamedNodeMap attributeMap, ModelElement? elementData)
	{
		foreach (IAttr attribute in attributeMap)
		{
			if (elementData is not null && elementData.Attributes.TryGetValue(attribute.LocalName, out HtmlAttribute? attributeData))
			{
				writer.Write('.');
				writer.Write(attributeData.FluentMethodName);
				writer.Write('(');
			}
			else
			{
				writer.Write(".WithCustomAttribute(");
				writer.Write(ToLiteral(attribute.LocalName));
				writer.Write(", ");
			}
			writer.Write(ToLiteral(attribute.Value));
			writer.Write(")");
		}
	}

	private static string ToLiteral(string? valueTextForCompiler)
	{
		if (valueTextForCompiler is { Length: 1 })
		{
			return Microsoft.CodeAnalysis.CSharp.SymbolDisplay.FormatLiteral(valueTextForCompiler[0], true);
		}
		else
		{
			return Microsoft.CodeAnalysis.CSharp.SymbolDisplay.FormatLiteral(valueTextForCompiler ?? "", true);
		}
	}

	private static bool MightHaveSignificantWhiteSpace(string elementName)
	{
		//This list is the list of elements where changing new lines, tabulation, or spacing could make a difference in functionality.
		//It might not be exhaustive.
		return elementName
			is "pre"
			or "code"
			or "textarea"
			or "style"
			or "script"
			or "xmp"; //depreciated
	}

	[GeneratedRegex(@"\s+")]
	private static partial Regex WhiteSpaceRegex();
}
