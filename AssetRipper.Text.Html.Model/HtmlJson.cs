using System.Text.Json;

namespace AssetRipper.Text.Html.Model;

public sealed record HtmlJson(List<HtmlElementData> Elements, List<string> GlobalAttributes, List<KeyValuePair<string, string>> AttributeDescriptions)
{
	public HtmlJson() : this([], [], [])
	{
	}

	public string ToJson()
	{
		return JsonSerializer.Serialize(this, HtmlJsonSerializerContext.Default.HtmlJson);
	}

	public static HtmlJson FromJson(string json)
	{
		return JsonSerializer.Deserialize(json, HtmlJsonSerializerContext.Default.HtmlJson) ?? new();
	}
}
