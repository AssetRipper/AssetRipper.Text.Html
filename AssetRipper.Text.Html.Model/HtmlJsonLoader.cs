using System.Text.Json;

namespace AssetRipper.Text.Html.Model;

public sealed class HtmlJsonLoader
{
	public static IReadOnlyDictionary<string, HtmlElement> Load(string path)
	{
		List<KeyValuePair<string, string[]>> data = JsonSerializer.Deserialize(File.ReadAllText(path), HtmlJsonSerializerContext.Default.ListKeyValuePairStringStringArray)
			?? throw new ArgumentException(null, nameof(path));

		Dictionary<string, HtmlElement> result = new();
		foreach ((string elementName, string[] attributeArray) in data)
		{
			result.Add(elementName, new HtmlElement(elementName, attributeArray));
		}

		return result;
	}
}
