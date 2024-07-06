// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Textarea : IHtmlElement<Textarea>,
	IAutocompleteAttribute<Textarea>,
	IColsAttribute<Textarea>,
	IDirNameAttribute<Textarea>,
	IDisabledAttribute<Textarea>,
	IEnterKeyHintAttribute<Textarea>,
	IFormAttribute<Textarea>,
	IInputModeAttribute<Textarea>,
	IMaxLengthAttribute<Textarea>,
	IMinLengthAttribute<Textarea>,
	INameAttribute<Textarea>,
	IPlaceholderAttribute<Textarea>,
	IReadonlyAttribute<Textarea>,
	IRequiredAttribute<Textarea>,
	IRowsAttribute<Textarea>,
	IWrapAttribute<Textarea>,
	IGlobalAttributes<Textarea>
{
	private const string ElementName = "textarea";
	private readonly TextWriter writer;

	public Textarea(TextWriter writer)
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

	public Textarea WithAccessKey(string? value = null)
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

	public Textarea WithAutocapitalize(string? value = null)
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

	public Textarea WithAutocomplete(string? value = null)
	{
		Autocomplete = value;
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

	public Textarea WithClass(string? value = null)
	{
		Class = value;
		return this;
	}

	public string? Cols
	{
		set
		{
			writer.Write(" cols=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithCols(string? value = null)
	{
		Cols = value;
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

	public Textarea WithContentEditable(string? value = null)
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

	public Textarea WithDir(string? value = null)
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

	public Textarea WithDirName(string? value = null)
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

	public Textarea WithDisabled(string? value = null)
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

	public Textarea WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? EnterKeyHint
	{
		set
		{
			writer.Write(" enterkeyhint=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithEnterKeyHint(string? value = null)
	{
		EnterKeyHint = value;
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

	public Textarea WithForm(string? value = null)
	{
		Form = value;
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

	public Textarea WithHidden(string? value = null)
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

	public Textarea WithId(string? value = null)
	{
		Id = value;
		return this;
	}

	public string? InputMode
	{
		set
		{
			writer.Write(" inputmode=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithInputMode(string? value = null)
	{
		InputMode = value;
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

	public Textarea WithItemProp(string? value = null)
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

	public Textarea WithLang(string? value = null)
	{
		Lang = value;
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

	public Textarea WithMaxLength(string? value = null)
	{
		MaxLength = value;
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

	public Textarea WithMinLength(string? value = null)
	{
		MinLength = value;
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

	public Textarea WithName(string? value = null)
	{
		Name = value;
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

	public Textarea WithPlaceholder(string? value = null)
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

	public Textarea WithReadonly(string? value = null)
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

	public Textarea WithRequired(string? value = null)
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

	public Textarea WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Rows
	{
		set
		{
			writer.Write(" rows=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithRows(string? value = null)
	{
		Rows = value;
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

	public Textarea WithSlot(string? value = null)
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

	public Textarea WithSpellCheck(string? value = null)
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

	public Textarea WithStyle(string? value = null)
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

	public Textarea WithTabIndex(string? value = null)
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

	public Textarea WithTitle(string? value = null)
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

	public Textarea WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public string? Wrap
	{
		set
		{
			writer.Write(" wrap=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithWrap(string? value = null)
	{
		Wrap = value;
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
	TextWriter IHtmlElement<Textarea>.Writer => writer;
	static Textarea IHtmlElement<Textarea>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Textarea>.IsVoidElement => false;
	static string IHtmlElement<Textarea>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Textarea>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
		"autocomplete",
		"class",
		"cols",
		"contenteditable",
		"dir",
		"dirname",
		"disabled",
		"draggable",
		"enterkeyhint",
		"form",
		"hidden",
		"id",
		"inputmode",
		"itemprop",
		"lang",
		"maxlength",
		"minlength",
		"name",
		"placeholder",
		"readonly",
		"required",
		"role",
		"rows",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"title",
		"translate",
		"wrap",
	];
}
