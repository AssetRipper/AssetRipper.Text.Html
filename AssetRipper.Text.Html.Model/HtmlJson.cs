namespace AssetRipper.Text.Html.Model;

public sealed record HtmlJson(List<KeyValuePair<string, string[]>> Elements, List<string> GlobalAttributes);
