using System.Text.Json;

namespace AssetRipper.Text.Html.Model;

public sealed record HtmlJson(List<KeyValuePair<string, List<string>>> Elements, List<string> GlobalAttributes)
{
	public HtmlJson() : this([], [])
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
