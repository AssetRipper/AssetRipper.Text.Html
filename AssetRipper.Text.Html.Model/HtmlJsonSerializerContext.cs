using System.Text.Json.Serialization;

namespace AssetRipper.Text.Html.Model;

[JsonSerializable(typeof(HtmlJson))]
[JsonSourceGenerationOptions(WriteIndented = true)]
internal partial class HtmlJsonSerializerContext : JsonSerializerContext
{
}
