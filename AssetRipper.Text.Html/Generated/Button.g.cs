// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Button : IHtmlElement<Button>,
	IDisabledAttribute<Button>,
	IFormAttribute<Button>,
	IFormActionAttribute<Button>,
	IFormEncTypeAttribute<Button>,
	IFormMethodAttribute<Button>,
	IFormNoValidateAttribute<Button>,
	IFormTargetAttribute<Button>,
	INameAttribute<Button>,
	ITypeAttribute<Button>,
	IValueAttribute<Button>,
	IGlobalAttributes<Button>
{
	private const string ElementName = "button";
	private readonly TextWriter writer;

	public Button(TextWriter writer)
	{
		this.writer = writer;
		writer.Write($"<{ElementName}");
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

	public Button WithAccessKey(string? value = null)
	{
		AccessKey = value;
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

	public Button WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
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

	public Button WithClass(string? value = null)
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

	public Button WithContentEditable(string? value = null)
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

	public Button WithDir(string? value = null)
	{
		Dir = value;
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

	public Button WithDisabled(string? value = null)
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

	public Button WithDraggable(string? value = null)
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

	public Button WithForm(string? value = null)
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

	public Button WithFormAction(string? value = null)
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

	public Button WithFormEncType(string? value = null)
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

	public Button WithFormMethod(string? value = null)
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

	public Button WithFormNoValidate(string? value = null)
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

	public Button WithFormTarget(string? value = null)
	{
		FormTarget = value;
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

	public Button WithHidden(string? value = null)
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

	public Button WithId(string? value = null)
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

	public Button WithItemProp(string? value = null)
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

	public Button WithLang(string? value = null)
	{
		Lang = value;
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

	public Button WithName(string? value = null)
	{
		Name = value;
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

	public Button WithRole(string? value = null)
	{
		Role = value;
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

	public Button WithSlot(string? value = null)
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

	public Button WithSpellCheck(string? value = null)
	{
		SpellCheck = value;
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

	public Button WithStyle(string? value = null)
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

	public Button WithTabIndex(string? value = null)
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

	public Button WithTitle(string? value = null)
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

	public Button WithTranslate(string? value = null)
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

	public Button WithType(string? value = null)
	{
		Type = value;
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

	public Button WithValue(string? value = null)
	{
		Value = value;
		return this;
	}

	public void Close() => writer.Write($"></{ElementName}>");

	/// <summary>
	/// End the opening tag, write some text, and write the closing tag.
	/// </summary>
	/// <remarks>
	/// The text is automatically Html-encoded.
	/// </remarks>
	public void Close(string? text)
	{
		writer.Write('>');
		global::System.Net.WebUtility.HtmlEncode(text, writer);
		writer.Write($"</{ElementName}>");
	}

	public HtmlElementCloser End()
	{
		writer.Write('>');
		return new HtmlElementCloser(writer, $"</{ElementName}>");
	}

	// IHtmlElement<TSelf> implementation
	TextWriter IHtmlElement<Button>.Writer => writer;
	static Button IHtmlElement<Button>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Button>.IsVoidElement => false;
	static string IHtmlElement<Button>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Button>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
		"class",
		"contenteditable",
		"dir",
		"disabled",
		"draggable",
		"form",
		"formaction",
		"formenctype",
		"formmethod",
		"formnovalidate",
		"formtarget",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"name",
		"role",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"title",
		"translate",
		"type",
		"value",
	];
}
