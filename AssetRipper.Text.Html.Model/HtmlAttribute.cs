namespace AssetRipper.Text.Html.Model;

public sealed class HtmlAttribute
{
	public string Name { get; }
	public string PropertyName { get; }
	public string FluentMethodName { get; }

	public HtmlAttribute(string name, string className)
	{
		Name = name;
		string pascal = HtmlHelper.ConvertKebabToPascal(name);
		PropertyName = HtmlHelper.MaybeAppendUnderscore(pascal, className);
		FluentMethodName = HtmlHelper.MaybeAppendUnderscore($"With{pascal}", className);
	}
}
