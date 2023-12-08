namespace AssetRipper.Text.Html.Model;

public sealed class HtmlElement
{
	public string Name { get; }
	public string ClassName { get; }
	public bool IsVoidElement { get; }
	public IReadOnlyDictionary<string, HtmlAttribute> Attributes { get; }

	public HtmlElement(string name, ReadOnlySpan<string> attributes)
	{
		Name = name;
		ClassName = HtmlHelper.ConvertKebabToPascal(name);
		IsVoidElement = HtmlHelper.IsVoidElement(name);
		Dictionary<string, HtmlAttribute> attributesDictionary = new();
		foreach (string attribute in attributes)
		{
			attributesDictionary.Add(attribute, new(attribute, ClassName));
		}
		Attributes = attributesDictionary;
	}
}
