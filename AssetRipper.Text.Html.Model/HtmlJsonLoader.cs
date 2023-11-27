using System.Text.Json;

namespace AssetRipper.Text.Html.Model;

public sealed class HtmlJsonLoader
{
	private const string NamespacePrefix = "AssetRipper.Text.Html.Model.";

	public static IReadOnlyDictionary<string, HtmlElement> Load()
	{
		using Stream stream = typeof(HtmlJsonLoader).Assembly.GetManifestResourceStream(NamespacePrefix + "html-elements-attributes.json")
			?? throw new NullReferenceException("Could not load resource stream.");

		string json = new StreamReader(stream).ReadToEnd();

		List<KeyValuePair<string, string[]>> data = JsonSerializer.Deserialize(json, HtmlJsonSerializerContext.Default.ListKeyValuePairStringStringArray)
			?? throw new NullReferenceException("Could not deserialize data from the json text.");

		Dictionary<string, HtmlElement> result = new();
		foreach ((string elementName, string[] attributeArray) in data)
		{
			result.Add(elementName, new HtmlElement(elementName, attributeArray));
		}

		return result;
	}
}
