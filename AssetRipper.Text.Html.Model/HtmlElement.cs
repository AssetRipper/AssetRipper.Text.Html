namespace AssetRipper.Text.Html.Model;

public sealed class HtmlElement
{
	public string Name { get; }
	public string ClassName { get; }
	public bool IsVoidElement { get; }
	public bool HasEndMethod => !IsVoidElement;
	public IReadOnlyList<HtmlAttribute> Attributes { get; }

	public HtmlElement(string name, ReadOnlySpan<string> attributes)
	{
		Name = name;
		ClassName = HtmlHelper.ConvertKebabToPascal(name);
		IsVoidElement = HtmlHelper.IsVoidElement(name);
		HtmlAttribute[] attributeArray = new HtmlAttribute[attributes.Length];
		for (int i = 0; i < attributes.Length; i++)
		{
			attributeArray[i] = new(attributes[i], ClassName);
		}
		Attributes = attributeArray;
	}
}
