using AssetRipper.Text.SourceGeneration;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json;

namespace HtmlSharp.Generator;

internal class Program
{
	private const string RepositoryRoot = "../../../../";
	private const string JsonFile = RepositoryRoot + "AssetRipper.Text.Html.Scraper/bin/Debug/net8.0/html-elements-attributes.json";
	private const string TargetProject = RepositoryRoot + "AssetRipper.Text.Html/";
	private const string GeneratedFolder = TargetProject + "Generated/";

	//https://developer.mozilla.org/en-US/docs/Glossary/Void_element
	private static readonly HashSet<string> VoidElements = [
		"area",
		"base",
		"br",
		"col",
		"embed",
		"hr",
		"img",
		"input",
		"link",
		"meta",
		"param",
		"source",
		"track",
		"wbr"
	];

	static void Main()
	{
		List<KeyValuePair<string, List<string>>> elements = JsonSerializer.Deserialize<List<KeyValuePair<string, List<string>>>>(
			File.OpenRead(JsonFile))
			?? throw new NullReferenceException();

		Directory.CreateDirectory(GeneratedFolder);

		foreach ((string element, List<string> attributes) in elements)
		{
			string className = ConvertToCSharpNaming(element, "");
			IndentedTextWriter writer = IndentedTextWriterFactory.Create(GeneratedFolder, className);

			writer.WriteGeneratedCodeWarning();
			writer.WriteLineNoTabs();
			writer.WriteLine("#nullable enable");
			writer.WriteLineNoTabs();
			writer.WriteFileScopedNamespace("AssetRipper.Text.Html");
			writer.WriteLineNoTabs();
			writer.WriteLine($"public readonly ref partial struct {className}");
			using (new CurlyBrackets(writer))
			{
				writer.WriteLine($"private const string ElementName = \"{element}\";");
				writer.WriteLine("private readonly TextWriter writer;");
				writer.WriteLineNoTabs();
				writer.WriteLine($"public {className}(TextWriter writer)");
				using (new CurlyBrackets(writer))
				{
					writer.WriteLine("this.writer = writer;");
					writer.WriteLine("writer.Write($\"<{ElementName}\");");
				}
				foreach (string attribute in attributes)
				{
					string propertyName = ConvertToCSharpNaming(attribute, className);

					writer.WriteLineNoTabs();
					writer.WriteLine($"public string? {propertyName}");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine("set");
						using (new CurlyBrackets(writer))
						{
							writer.WriteLine($"writer.Write(\" {attribute}=\\\"\");");
							writer.WriteLine("writer.Write(value);");
							writer.WriteLine("writer.Write('\"');");
						}
					}
					writer.WriteLineNoTabs();
					writer.WriteLine($"public {className} With{propertyName}(string? value = null)");
					using (new CurlyBrackets(writer))
					{
						writer.WriteLine($"{propertyName} = value;");
						writer.WriteLine("return this;");
					}
				}
				writer.WriteLineNoTabs();
				writer.WriteLine($"public {className} WithCustomAttribute(string key, string? value = null)");
				using (new CurlyBrackets(writer))
				{
					writer.WriteLine("WriteKey(key);");
					writer.WriteLine("WriteValue(value);");
					writer.WriteLine("return this;");
				}
				writer.WriteLineNoTabs();
				writer.WriteLine($"public {className} WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)");
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
				if (!VoidElements.Contains(element))
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
			Console.WriteLine(element);
		}
		Console.WriteLine("Done!");
	}

	static string ConvertToCSharpNaming(string kebabCase, string className)
	{
		StringBuilder pascalCaseBuilder = new(kebabCase.Length);

		bool capitalizeNext = true;

		foreach (char c in kebabCase)
		{
			if (c == '-')
			{
				capitalizeNext = true;
			}
			else
			{
				pascalCaseBuilder.Append(capitalizeNext ? char.ToUpperInvariant(c) : c);
				capitalizeNext = false;
			}
		}

		if (pascalCaseBuilder.Equals(className))
		{
			pascalCaseBuilder.Append('_');
		}

		return pascalCaseBuilder.ToString();
	}
}
