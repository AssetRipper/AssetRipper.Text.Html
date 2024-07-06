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
		ClassName = HtmlHelper.ConvertKebabToPascal(name);
		IsVoidElement = HtmlHelper.IsVoidElement(name);
		Dictionary<string, HtmlAttribute> dictionary = new();
		foreach (string attribute in attributes)
		{
			dictionary.Add(attribute, attributeDictionary[attribute]);
		}
		Attributes = dictionary;
	}
}
