namespace AssetRipper.Text.Html.Model;

public sealed class HtmlAttribute
{
	public string Name { get; }
	public string InterfaceName => Global ? "IGlobalAttributes" : $"I{PropertyName}Attribute";
	public string PropertyName { get; }
	public string FluentMethodName { get; }
	public bool Global { get; }

	public HtmlAttribute(string name, bool global)
	{
		Name = name;
		PropertyName = GetPascalName(name);
		FluentMethodName = $"With{GetPascalName(name)}";
		Global = global;
	}

	public string GetPropertyName(string elementClassName)
	{
		return HtmlHelper.MaybeAppendUnderscore(PropertyName, elementClassName);
	}

	public string GetFluentMethodName(string elementClassName)
	{
		return HtmlHelper.MaybeAppendUnderscore(FluentMethodName, elementClassName);
	}

	private static string GetPascalName(string name) => name switch
	{
		"accesskey" => "AccessKey",
		"bgcolor" => "BgColor",
		"colspan" => "ColSpan",
		"contenteditable" => "ContentEditable",
		"crossorigin" => "CrossOrigin",
		"datetime" => "DateTime",
		"dirname" => "DirName",
		"enterkeyhint" => "EnterKeyHint",
		"formaction" => "FormAction",
		"formenctype" => "FormEncType",
		"formmethod" => "FormMethod",
		"formnovalidate" => "FormNoValidate",
		"formtarget" => "FormTarget",
		"hreflang" => "HrefLang",
		"inputmode" => "InputMode",
		"ismap" => "IsMap",
		"itemprop" => "ItemProp",
		"playsinline" => "PlaysInline",
		"minlength" => "MinLength",
		"maxlength" => "MaxLength",
		"referrerpolicy" => "ReferrerPolicy",
		"rowspan" => "RowSpan",
		"spellcheck" => "SpellCheck",
		"srclang" => "SrcLang",
		"srcset" => "SrcSet",
		"srcdoc" => "SrcDoc",
		"tabindex" => "TabIndex",
		"usemap" => "UseMap",
		_ => HtmlHelper.ConvertKebabToPascal(name),
	};
}
