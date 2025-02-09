using AssetRipper.Text.Html.Model;
using AssetRipper.Text.SourceGeneration;
using Microsoft.CodeAnalysis;
using SGF;
using System.CodeDom.Compiler;

namespace HtmlSharp.Generator;

[IncrementalGenerator]
public sealed class HtmlGenerator : IncrementalGenerator
{
	public HtmlGenerator() : base(nameof(HtmlGenerator))
	{
	}

	public override void OnInitialize(SgfInitializationContext context)
	{
		context.RegisterPostInitializationOutput(GenerateCode);
	}

	private static void GenerateCode(IncrementalGeneratorPostInitializationContext context)
	{
		HtmlJsonLoader.Load(out List<HtmlAttribute> globalAttributes, out List<HtmlAttribute> localAttributes, out List<HtmlElement> elements);

		// Global attributes
		{
			StringWriter stringWriter = new()
			{
				NewLine = "\n",
			};
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(stringWriter);

			writer.WriteGeneratedCodeWarning();
			writer.WriteLineNoTabs();
			writer.WriteLine("#nullable enable");
			writer.WriteLineNoTabs();
			writer.WriteFileScopedNamespace("AssetRipper.Text.Html");
			writer.WriteLineNoTabs();
			writer.WriteLine("public interface IGlobalAttributes<TSelf> where TSelf : IGlobalAttributes<TSelf>, allows ref struct");
			using (new CurlyBrackets(writer))
			{
				for (int i = 0; i < globalAttributes.Count; i++)
				{
					HtmlAttribute attribute = globalAttributes[i];
					if (i > 0)
					{
						writer.WriteLineNoTabs();
					}
					WriteAttributeInterfacePropertyAndMethods(writer, attribute);
				}
			}

			context.AddSource("IGlobalAttributes.g.cs", stringWriter.ToString());
		}

		// Local attributes
		foreach (HtmlAttribute attribute in localAttributes)
		{
			StringWriter stringWriter = new()
			{
				NewLine = "\n",
			};
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(stringWriter);

			writer.WriteGeneratedCodeWarning();
			writer.WriteLineNoTabs();
			writer.WriteLine("#nullable enable");
			writer.WriteLineNoTabs();
			writer.WriteFileScopedNamespace("AssetRipper.Text.Html");
			writer.WriteLineNoTabs();
			writer.WriteLine($"public interface {attribute.InterfaceName}<TSelf> where TSelf : {attribute.InterfaceName}<TSelf>, allows ref struct");
			using (new CurlyBrackets(writer))
			{
				WriteAttributeInterfacePropertyAndMethods(writer, attribute);
			}

			context.AddSource($"{attribute.InterfaceName}.g.cs", stringWriter.ToString());
		}

		foreach (HtmlElement element in elements)
		{
			StringWriter stringWriter = new()
			{
				NewLine = "\n",
			};
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(stringWriter);

			writer.WriteGeneratedCodeWarning();
			writer.WriteLineNoTabs();
			writer.WriteLine("#nullable enable");
			writer.WriteLineNoTabs();
			writer.WriteFileScopedNamespace("AssetRipper.Text.Html");
			writer.WriteLineNoTabs();
			writer.WriteLine($"public readonly ref partial struct {element.ClassName} : IHtmlElement<{element.ClassName}>,");
			using (new Indented(writer))
			{
				foreach (HtmlAttribute attribute in element.Attributes.Values.Where(a => !a.Global))
				{
					writer.WriteLine($"{attribute.InterfaceName}<{element.ClassName}>,");
				}
				writer.WriteLine($"IGlobalAttributes<{element.ClassName}>");
			}

			using (new CurlyBrackets(writer))
			{
				writer.WriteLine($"private const string ElementName = \"{element.Name}\";");
				writer.WriteLine("private readonly TextWriter writer;");
				writer.WriteLineNoTabs();
				writer.WriteLine($"public {element.ClassName}(TextWriter writer)");
				using (new CurlyBrackets(writer))
				{
					writer.WriteLine("this.writer = writer;");
					writer.WriteLine("writer.Write($\"<{ElementName}\");");
				}
				foreach (HtmlAttribute attribute in element.Attributes.Values)
				{
					writer.WriteLineNoTabs();

					string propertyName = attribute.GetPropertyName(element.ClassName);
					bool needExplicitPropertyImplementation = propertyName != attribute.PropertyName;
					string explicitPropertyName = $"{attribute.InterfaceName}<{element.ClassName}>.{attribute.PropertyName}";
					if (needExplicitPropertyImplementation)
					{
						writer.WriteInheritDocumentation(explicitPropertyName.Replace('<', '{').Replace('>', '}'));
					}
					else
					{
						writer.WriteInheritDocumentation();
					}
					writer.WriteLine($"public string? {propertyName}");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine("set");
						using (new CurlyBrackets(writer))
						{
							writer.WriteLine($"writer.Write(\" {attribute.Name}=\\\"\");");
							writer.WriteLine("writer.Write(value);");
							writer.WriteLine("writer.Write('\"');");
						}
					}
					if (needExplicitPropertyImplementation)
					{
						writer.WriteLineNoTabs();
						writer.WriteInheritDocumentation();
						writer.WriteLine($"string? {explicitPropertyName}");
						using (new CurlyBrackets(writer))
						{
							writer.WriteLine($"set => {propertyName} = value;");
						}
					}

					writer.WriteLineNoTabs();

					string fluentMethodName = attribute.GetFluentMethodName(element.ClassName);
					bool needExplicitMethodImplementation = fluentMethodName != attribute.FluentMethodName;
					string explicitFluentMethodName = $"{attribute.InterfaceName}<{element.ClassName}>.{attribute.FluentMethodName}";
					if (needExplicitMethodImplementation)
					{
						writer.WriteInheritDocumentation(explicitFluentMethodName.Replace('<', '{').Replace('>', '}'));
					}
					else
					{
						writer.WriteInheritDocumentation();
					}
					writer.WriteLine($"public {element.ClassName} {fluentMethodName}(string? value = null)");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine($"{attribute.GetPropertyName(element.ClassName)} = value;");
						writer.WriteLine("return this;");
					}
					if (needExplicitMethodImplementation)
					{
						writer.WriteLineNoTabs();
						writer.WriteInheritDocumentation();
						writer.WriteLine($"{element.ClassName} {explicitFluentMethodName}(string? value = null)");
						using (new CurlyBrackets(writer))
						{
							writer.WriteLine($"return {fluentMethodName}(value);");
						}
					}
				}

				if (element.IsVoidElement)
				{
					writer.WriteLineNoTabs();
					writer.WriteInheritDocumentation();
					writer.WriteLine("public void Close() => writer.Write(\"/>\");");

					writer.WriteLineNoTabs();
					writer.WriteInheritDocumentation();
					writer.WriteLine($"HtmlElementCloser IHtmlElement<{element.ClassName}>.End() => throw new NotSupportedException();");
				}
				else
				{
					writer.WriteLineNoTabs();
					writer.WriteInheritDocumentation();
					writer.WriteLine("public void Close() => writer.Write($\"></{ElementName}>\");");

					writer.WriteLineNoTabs();
					writer.WriteSummaryDocumentation("End the opening tag, write some text, and write the closing tag.");
					writer.WriteRemarksDocumentation("The text is automatically Html-encoded.");
					writer.WriteLine("public void Close(string? text)");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine("writer.Write('>');");
						writer.WriteLine("global::System.Net.WebUtility.HtmlEncode(text, writer);");
						writer.WriteLine("writer.Write($\"</{ElementName}>\");");
					}

					writer.WriteLineNoTabs();
					writer.WriteInheritDocumentation();
					writer.WriteLine("public HtmlElementCloser End()");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine("writer.Write('>');");
						writer.WriteLine("return new HtmlElementCloser(writer, $\"</{ElementName}>\");");
					}
				}

				// IHtmlElement<TSelf> implementation
				{
					writer.WriteLineNoTabs();
					writer.WriteComment("IHtmlElement<TSelf> implementation");
					writer.WriteLineNoTabs();
					writer.WriteInheritDocumentation();
					writer.WriteLine($"TextWriter IHtmlElement<{element.ClassName}>.Writer => writer;");
					writer.WriteInheritDocumentation();
					writer.WriteLine($"static {element.ClassName} IHtmlElement<{element.ClassName}>.Create(TextWriter writer) => new(writer);");
					writer.WriteInheritDocumentation();
					writer.WriteLine($"static bool IHtmlElement<{element.ClassName}>.IsVoidElement => {element.IsVoidElement.ToString().ToLowerInvariant()};");
					writer.WriteInheritDocumentation();
					writer.WriteLine($"static string IHtmlElement<{element.ClassName}>.Name => ElementName;");
					writer.WriteInheritDocumentation();
					writer.WriteLine($"static ReadOnlySpan<string> IHtmlElement<{element.ClassName}>.SupportedAttributes => _supportedAttributes;");
					writer.WriteLine("private static readonly string[] _supportedAttributes =");
					writer.WriteLine('[');
					using (new Indented(writer))
					{
						foreach (HtmlAttribute attribute in element.Attributes.Values)
						{
							writer.WriteLine($"\"{attribute.Name}\",");
						}
					}
					writer.WriteLine("];");
				}
			}

			context.AddSource($"{element.ClassName}.g.cs", stringWriter.ToString());
		}
	}

	private static void WriteAttributeInterfacePropertyAndMethods(IndentedTextWriter writer, HtmlAttribute attribute)
	{
		writer.WriteSummaryDocumentation($"Includes the {attribute.Name} attribute.");
		writer.WriteRemarksDocumentation($"The value is NOT automatically Html-encoded.\nThis is the same as calling {XmlFormatter.SeeCref(attribute.FluentMethodName)}.");
		writer.WriteLine($"string? {attribute.PropertyName} {{ set; }}");

		writer.WriteLineNoTabs();

		writer.WriteSummaryDocumentation($"Includes the {attribute.Name} attribute.");
		writer.WriteRemarksDocumentation($"This is the same as setting {XmlFormatter.SeeCref(attribute.PropertyName)}.");
		writer.WriteParameterDocumentation("value", "The value to set. It is NOT automatically Html-encoded.");
		writer.WriteLine($"TSelf {attribute.FluentMethodName}(string? value = null);");
	}
}
