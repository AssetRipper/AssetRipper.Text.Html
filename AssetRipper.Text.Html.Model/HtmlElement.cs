namespace AssetRipper.Text.Html.Model;

public sealed class HtmlElement
{
	public string Name { get; }
	public string ClassName { get; }
	public bool IsVoidElement { get; }
	public IReadOnlyDictionary<string, HtmlAttribute> Attributes { get; }

	public HtmlElement(string name, IEnumerable<string> attributes, Dictionary<string, HtmlAttribute> attributeDictionary)
	{
		Name = name;
		ClassName = GetPascalName(name);
		IsVoidElement = HtmlHelper.IsVoidElement(name);
		Dictionary<string, HtmlAttribute> dictionary = new();
		foreach (string attribute in attributes)
		{
			dictionary.Add(attribute, attributeDictionary[attribute]);
		}
		Attributes = dictionary;
	}

	private static string GetPascalName(string name) => name switch
	{
		"blockquote" => "BlockQuote",
		"colgroup" => "ColGroup",
		"datalist" => "DataList",
		"fencedframe" => "FencedFrame",
		"fieldset" => "FieldSet",
		"figcaption" => "FigCaption",
		"frameset" => "FrameSet",
		"hgroup" => "HGroup",
		"iframe" => "IFrame",
		"menuitem" => "MenuItem",
		"nobr" => "NoBr",
		"noembed" => "NoEmbed",
		"noframes" => "NoFrames",
		"noscript" => "NoScript",
		"optgroup" => "OptGroup",
		"plaintext" => "PlainText",
		"textarea" => "TextArea",
		_ => HtmlHelper.ConvertKebabToPascal(name),
	};
}
