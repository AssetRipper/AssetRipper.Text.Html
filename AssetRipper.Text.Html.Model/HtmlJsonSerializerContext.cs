using System.Text.Json.Serialization;

namespace AssetRipper.Text.Html.Model;

[JsonSerializable(typeof(HtmlJson))]
internal partial class HtmlJsonSerializerContext : JsonSerializerContext
{
}
