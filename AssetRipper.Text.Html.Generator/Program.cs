using AssetRipper.Text.Html.Model;
using AssetRipper.Text.SourceGeneration;
using System.CodeDom.Compiler;

namespace HtmlSharp.Generator;

internal class Program
{
	private const string RepositoryRoot = "../../../../";
	private const string JsonFile = RepositoryRoot + "AssetRipper.Text.Html.Scraper/bin/Debug/net8.0/html-elements-attributes.json";
	private const string TargetProject = RepositoryRoot + "AssetRipper.Text.Html/";
	private const string GeneratedFolder = TargetProject + "Generated/";

	static void Main()
	{
		IReadOnlyDictionary<string, HtmlElement> elements = HtmlJsonLoader.Load(JsonFile);

		Directory.CreateDirectory(GeneratedFolder);

		foreach (HtmlElement element in elements.Values)
		{
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(GeneratedFolder, element.ClassName);

			writer.WriteGeneratedCodeWarning();
			writer.WriteLineNoTabs();
			writer.WriteLine("#nullable enable");
			writer.WriteLineNoTabs();
			writer.WriteFileScopedNamespace("AssetRipper.Text.Html");
			writer.WriteLineNoTabs();
			writer.WriteLine($"public readonly ref partial struct {element.ClassName}");
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
				foreach (HtmlAttribute attribute in element.Attributes)
				{
					writer.WriteLineNoTabs();
					writer.WriteLine($"public string? {attribute.PropertyName}");
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
					writer.WriteLineNoTabs();
					writer.WriteLine($"public {element.ClassName} {attribute.FluentMethodName}(string? value = null)");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine($"{attribute.PropertyName} = value;");
						writer.WriteLine("return this;");
					}
				}
				writer.WriteLineNoTabs();
				writer.WriteLine($"public {element.ClassName} WithCustomAttribute(string key, string? value = null)");
				using (new CurlyBrackets(writer))
				{
					writer.WriteLine("WriteKey(key);");
					writer.WriteLine("WriteValue(value);");
					writer.WriteLine("return this;");
				}
				writer.WriteLineNoTabs();
				writer.WriteLine($"public {element.ClassName} WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)");
				using (new CurlyBrackets(writer))
				{
					writer.WriteLine("foreach ((string key, string? value) in attributes)");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine("WriteKey(key);");
						writer.WriteLine("WriteValue(value);");
					}
					writer.WriteLine("return this;");
				}
				writer.WriteLineNoTabs();
				writer.WriteLine("private void WriteKey(string key)");
				using (new CurlyBrackets(writer))
				{
					writer.WriteLine("writer.Write(' ');");
					writer.WriteLine("writer.Write(key);");
				}
				writer.WriteLineNoTabs();
				writer.WriteLine("private void WriteValue(string? value)");
				using (new CurlyBrackets(writer))
				{
					writer.WriteLine("writer.Write(\"=\\\"\");");
					writer.WriteLine("writer.Write(value);");
					writer.WriteLine("writer.Write('\"');");
				}
				writer.WriteLineNoTabs();
				writer.WriteLine("public void Close() => writer.Write(\"/>\");");
				if (element.HasEndMethod)
				{
					writer.WriteLineNoTabs();
					writer.WriteLine("public HtmlElementCloser End()");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine("writer.Write('>');");
						writer.WriteLine("return new HtmlElementCloser(writer, $\"</{ElementName}>\");");
					}
				}
			}
			Console.WriteLine(element.Name);
		}
		Console.WriteLine("Done!");
	}
}
