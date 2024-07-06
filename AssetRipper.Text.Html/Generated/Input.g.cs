// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Input : IHtmlElement<Input>,
	IAcceptAttribute<Input>,
	IAltAttribute<Input>,
	IAutocompleteAttribute<Input>,
	ICaptureAttribute<Input>,
	ICheckedAttribute<Input>,
	IDirNameAttribute<Input>,
	IDisabledAttribute<Input>,
	IFormAttribute<Input>,
	IFormActionAttribute<Input>,
	IFormEncTypeAttribute<Input>,
	IFormMethodAttribute<Input>,
	IFormNoValidateAttribute<Input>,
	IFormTargetAttribute<Input>,
	IHeightAttribute<Input>,
	IListAttribute<Input>,
	IMaxAttribute<Input>,
	IMaxLengthAttribute<Input>,
	IMinAttribute<Input>,
	IMinLengthAttribute<Input>,
	IMultipleAttribute<Input>,
	INameAttribute<Input>,
	IPatternAttribute<Input>,
	IPlaceholderAttribute<Input>,
	IReadonlyAttribute<Input>,
	IRequiredAttribute<Input>,
	ISizeAttribute<Input>,
	ISrcAttribute<Input>,
	IStepAttribute<Input>,
	ITypeAttribute<Input>,
	IUseMapAttribute<Input>,
	IValueAttribute<Input>,
	IWidthAttribute<Input>,
	IGlobalAttributes<Input>
{
	private const string ElementName = "input";
	private readonly TextWriter writer;

	public Input(TextWriter writer)
	{
		this.writer = writer;
		writer.Write($"<{ElementName}");
	}

	public string? Accept
	{
		set
		{
			writer.Write(" accept=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithAccept(string? value = null)
	{
		Accept = value;
		return this;
	}

	public string? AccessKey
	{
		set
		{
			writer.Write(" accesskey=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithAccessKey(string? value = null)
	{
		AccessKey = value;
		return this;
	}

	public string? Alt
	{
		set
		{
			writer.Write(" alt=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithAlt(string? value = null)
	{
		Alt = value;
		return this;
	}

	public string? Autocapitalize
	{
		set
		{
			writer.Write(" autocapitalize=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
		return this;
	}

	public string? Autocomplete
	{
		set
		{
			writer.Write(" autocomplete=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithAutocomplete(string? value = null)
	{
		Autocomplete = value;
		return this;
	}

	public string? Capture
	{
		set
		{
			writer.Write(" capture=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithCapture(string? value = null)
	{
		Capture = value;
		return this;
	}

	public string? Checked
	{
		set
		{
			writer.Write(" checked=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithChecked(string? value = null)
	{
		Checked = value;
		return this;
	}

	public string? Class
	{
		set
		{
			writer.Write(" class=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithClass(string? value = null)
	{
		Class = value;
		return this;
	}

	public string? ContentEditable
	{
		set
		{
			writer.Write(" contenteditable=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithContentEditable(string? value = null)
	{
		ContentEditable = value;
		return this;
	}

	public string? Dir
	{
		set
		{
			writer.Write(" dir=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithDir(string? value = null)
	{
		Dir = value;
		return this;
	}

	public string? DirName
	{
		set
		{
			writer.Write(" dirname=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithDirName(string? value = null)
	{
		DirName = value;
		return this;
	}

	public string? Disabled
	{
		set
		{
			writer.Write(" disabled=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithDisabled(string? value = null)
	{
		Disabled = value;
		return this;
	}

	public string? Draggable
	{
		set
		{
			writer.Write(" draggable=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? Form
	{
		set
		{
			writer.Write(" form=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithForm(string? value = null)
	{
		Form = value;
		return this;
	}

	public string? FormAction
	{
		set
		{
			writer.Write(" formaction=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithFormAction(string? value = null)
	{
		FormAction = value;
		return this;
	}

	public string? FormEncType
	{
		set
		{
			writer.Write(" formenctype=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithFormEncType(string? value = null)
	{
		FormEncType = value;
		return this;
	}

	public string? FormMethod
	{
		set
		{
			writer.Write(" formmethod=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithFormMethod(string? value = null)
	{
		FormMethod = value;
		return this;
	}

	public string? FormNoValidate
	{
		set
		{
			writer.Write(" formnovalidate=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithFormNoValidate(string? value = null)
	{
		FormNoValidate = value;
		return this;
	}

	public string? FormTarget
	{
		set
		{
			writer.Write(" formtarget=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithFormTarget(string? value = null)
	{
		FormTarget = value;
		return this;
	}

	public string? Height
	{
		set
		{
			writer.Write(" height=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithHeight(string? value = null)
	{
		Height = value;
		return this;
	}

	public string? Hidden
	{
		set
		{
			writer.Write(" hidden=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithHidden(string? value = null)
	{
		Hidden = value;
		return this;
	}

	public string? Id
	{
		set
		{
			writer.Write(" id=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithId(string? value = null)
	{
		Id = value;
		return this;
	}

	public string? ItemProp
	{
		set
		{
			writer.Write(" itemprop=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithItemProp(string? value = null)
	{
		ItemProp = value;
		return this;
	}

	public string? Lang
	{
		set
		{
			writer.Write(" lang=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? List
	{
		set
		{
			writer.Write(" list=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithList(string? value = null)
	{
		List = value;
		return this;
	}

	public string? Max
	{
		set
		{
			writer.Write(" max=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithMax(string? value = null)
	{
		Max = value;
		return this;
	}

	public string? MaxLength
	{
		set
		{
			writer.Write(" maxlength=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithMaxLength(string? value = null)
	{
		MaxLength = value;
		return this;
	}

	public string? Min
	{
		set
		{
			writer.Write(" min=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithMin(string? value = null)
	{
		Min = value;
		return this;
	}

	public string? MinLength
	{
		set
		{
			writer.Write(" minlength=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithMinLength(string? value = null)
	{
		MinLength = value;
		return this;
	}

	public string? Multiple
	{
		set
		{
			writer.Write(" multiple=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithMultiple(string? value = null)
	{
		Multiple = value;
		return this;
	}

	public string? Name
	{
		set
		{
			writer.Write(" name=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithName(string? value = null)
	{
		Name = value;
		return this;
	}

	public string? Pattern
	{
		set
		{
			writer.Write(" pattern=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithPattern(string? value = null)
	{
		Pattern = value;
		return this;
	}

	public string? Placeholder
	{
		set
		{
			writer.Write(" placeholder=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithPlaceholder(string? value = null)
	{
		Placeholder = value;
		return this;
	}

	public string? Readonly
	{
		set
		{
			writer.Write(" readonly=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithReadonly(string? value = null)
	{
		Readonly = value;
		return this;
	}

	public string? Required
	{
		set
		{
			writer.Write(" required=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithRequired(string? value = null)
	{
		Required = value;
		return this;
	}

	public string? Role
	{
		set
		{
			writer.Write(" role=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Size
	{
		set
		{
			writer.Write(" size=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithSize(string? value = null)
	{
		Size = value;
		return this;
	}

	public string? Slot
	{
		set
		{
			writer.Write(" slot=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithSlot(string? value = null)
	{
		Slot = value;
		return this;
	}

	public string? SpellCheck
	{
		set
		{
			writer.Write(" spellcheck=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithSpellCheck(string? value = null)
	{
		SpellCheck = value;
		return this;
	}

	public string? Src
	{
		set
		{
			writer.Write(" src=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithSrc(string? value = null)
	{
		Src = value;
		return this;
	}

	public string? Step
	{
		set
		{
			writer.Write(" step=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithStep(string? value = null)
	{
		Step = value;
		return this;
	}

	public string? Style
	{
		set
		{
			writer.Write(" style=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithStyle(string? value = null)
	{
		Style = value;
		return this;
	}

	public string? TabIndex
	{
		set
		{
			writer.Write(" tabindex=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithTabIndex(string? value = null)
	{
		TabIndex = value;
		return this;
	}

	public string? Title
	{
		set
		{
			writer.Write(" title=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithTitle(string? value = null)
	{
		Title = value;
		return this;
	}

	public string? Translate
	{
		set
		{
			writer.Write(" translate=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public string? Type
	{
		set
		{
			writer.Write(" type=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithType(string? value = null)
	{
		Type = value;
		return this;
	}

	public string? UseMap
	{
		set
		{
			writer.Write(" usemap=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithUseMap(string? value = null)
	{
		UseMap = value;
		return this;
	}

	public string? Value
	{
		set
		{
			writer.Write(" value=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithValue(string? value = null)
	{
		Value = value;
		return this;
	}

	public string? Width
	{
		set
		{
			writer.Write(" width=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Input WithWidth(string? value = null)
	{
		Width = value;
		return this;
	}

	public void Close() => writer.Write("/>");

	HtmlElementCloser IHtmlElement<Input>.End() => throw new NotSupportedException();

	// IHtmlElement<TSelf> implementation
	TextWriter IHtmlElement<Input>.Writer => writer;
	static Input IHtmlElement<Input>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Input>.IsVoidElement => true;
	static string IHtmlElement<Input>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Input>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accept",
		"accesskey",
		"alt",
		"autocapitalize",
		"autocomplete",
		"capture",
		"checked",
		"class",
		"contenteditable",
		"dir",
		"dirname",
		"disabled",
		"draggable",
		"form",
		"formaction",
		"formenctype",
		"formmethod",
		"formnovalidate",
		"formtarget",
		"height",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"list",
		"max",
		"maxlength",
		"min",
		"minlength",
		"multiple",
		"name",
		"pattern",
		"placeholder",
		"readonly",
		"required",
		"role",
		"size",
		"slot",
		"spellcheck",
		"src",
		"step",
		"style",
		"tabindex",
		"title",
		"translate",
		"type",
		"usemap",
		"value",
		"width",
	];
}
