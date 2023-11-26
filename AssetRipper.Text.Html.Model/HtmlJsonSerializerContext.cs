using System.Text.Json.Serialization;

namespace AssetRipper.Text.Html.Model;

[JsonSerializable(typeof(List<KeyValuePair<string, string[]>>))]
internal partial class HtmlJsonSerializerContext : JsonSerializerContext
{
}
