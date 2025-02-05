using AssetRipper.Text.Html.Model;
using AssetRipper.Text.SourceGeneration;
using System.CodeDom.Compiler;

namespace HtmlSharp.Generator;

internal class Program
{
	private const string RepositoryRoot = "../../../../";
	private const string TargetProject = RepositoryRoot + "AssetRipper.Text.Html/";
	private const string GeneratedFolder = TargetProject + "Generated/";

	static void Main()
	{
		HtmlJsonLoader.Load(out List<HtmlAttribute> globalAttributes, out List<HtmlAttribute> localAttributes, out List<HtmlElement> elements);

		Directory.CreateDirectory(GeneratedFolder);

		// Global attributes
		{
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(GeneratedFolder, "IGlobalAttributes");

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
					writer.WriteLine($"string {attribute.PropertyName} {{ set; }}");
					writer.WriteLineNoTabs();
					writer.WriteLine($"TSelf {attribute.FluentMethodName}(string? value = null);");
				}
			}
		}

		// Local attributes
		foreach (HtmlAttribute attribute in localAttributes)
		{
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(GeneratedFolder, attribute.InterfaceName);

			writer.WriteGeneratedCodeWarning();
			writer.WriteLineNoTabs();
			writer.WriteLine("#nullable enable");
			writer.WriteLineNoTabs();
			writer.WriteFileScopedNamespace("AssetRipper.Text.Html");
			writer.WriteLineNoTabs();
			writer.WriteLine($"public interface {attribute.InterfaceName}<TSelf> where TSelf : {attribute.InterfaceName}<TSelf>, allows ref struct");
			using (new CurlyBrackets(writer))
			{
				writer.WriteLine($"string {attribute.PropertyName} {{ set; }}");
				writer.WriteLineNoTabs();
				writer.WriteLine($"TSelf {attribute.FluentMethodName}(string? value = null);");
			}
		}

		foreach (HtmlElement element in elements)
		{
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(GeneratedFolder, element.ClassName);

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
					string propertyName = attribute.GetPropertyName(element.ClassName);
					writer.WriteLineNoTabs();
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
					if (propertyName != attribute.PropertyName)
					{
						writer.WriteLineNoTabs();
						writer.WriteLine($"string {attribute.InterfaceName}<{element.ClassName}>.{attribute.PropertyName}");
						using (new CurlyBrackets(writer))
						{
							writer.WriteLine($"set => {propertyName} = value;");
						}
					}

					string fluentMethodName = attribute.GetFluentMethodName(element.ClassName);
					writer.WriteLineNoTabs();
					writer.WriteLine($"public {element.ClassName} {fluentMethodName}(string? value = null)");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine($"{attribute.GetPropertyName(element.ClassName)} = value;");
						writer.WriteLine("return this;");
					}
					if (fluentMethodName != attribute.FluentMethodName)
					{
						writer.WriteLineNoTabs();
						writer.WriteLine($"{element.ClassName} {attribute.InterfaceName}<{element.ClassName}>.{attribute.FluentMethodName}(string? value = null)");
						using (new CurlyBrackets(writer))
						{
							writer.WriteLine($"return {fluentMethodName}(value);");
						}
					}
				}

				if (element.IsVoidElement)
				{
					writer.WriteLineNoTabs();
					writer.WriteLine("public void Close() => writer.Write(\"/>\");");

					writer.WriteLineNoTabs();
					writer.WriteLine($"HtmlElementCloser IHtmlElement<{element.ClassName}>.End() => throw new NotSupportedException();");
				}
				else
				{
					writer.WriteLineNoTabs();
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
					writer.WriteLine($"TextWriter IHtmlElement<{element.ClassName}>.Writer => writer;");
					writer.WriteLine($"static {element.ClassName} IHtmlElement<{element.ClassName}>.Create(TextWriter writer) => new(writer);");
					writer.WriteLine($"static bool IHtmlElement<{element.ClassName}>.IsVoidElement => {element.IsVoidElement.ToString().ToLowerInvariant()};");
					writer.WriteLine($"static string IHtmlElement<{element.ClassName}>.Name => ElementName;");
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
			Console.WriteLine(element.Name);
		}
		Console.WriteLine("Done!");
	}
}
