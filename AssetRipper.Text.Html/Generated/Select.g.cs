// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Select : IHtmlElement<Select>,
	IAutocompleteAttribute<Select>,
	IDisabledAttribute<Select>,
	IFormAttribute<Select>,
	IMultipleAttribute<Select>,
	INameAttribute<Select>,
	IRequiredAttribute<Select>,
	ISizeAttribute<Select>,
	IGlobalAttributes<Select>
{
	private const string ElementName = "select";
	private readonly TextWriter writer;

	public Select(TextWriter writer)
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

	public Select WithAccessKey(string? value = null)
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

	public Select WithAutocapitalize(string? value = null)
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

	public Select WithAutocomplete(string? value = null)
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

	public Select WithClass(string? value = null)
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

	public Select WithContentEditable(string? value = null)
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

	public Select WithDir(string? value = null)
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

	public Select WithDisabled(string? value = null)
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

	public Select WithDraggable(string? value = null)
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

	public Select WithForm(string? value = null)
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

	public Select WithHidden(string? value = null)
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

	public Select WithId(string? value = null)
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

	public Select WithItemProp(string? value = null)
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

	public Select WithLang(string? value = null)
	{
		Lang = value;
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

	public Select WithMultiple(string? value = null)
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

	public Select WithName(string? value = null)
	{
		Name = value;
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

	public Select WithRequired(string? value = null)
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

	public Select WithRole(string? value = null)
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

	public Select WithSize(string? value = null)
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

	public Select WithSlot(string? value = null)
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

	public Select WithSpellCheck(string? value = null)
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

	public Select WithStyle(string? value = null)
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

	public Select WithTabIndex(string? value = null)
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

	public Select WithTitle(string? value = null)
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

	public Select WithTranslate(string? value = null)
	{
		Translate = value;
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
	TextWriter IHtmlElement<Select>.Writer => writer;
	static Select IHtmlElement<Select>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Select>.IsVoidElement => false;
	static string IHtmlElement<Select>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Select>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
		"autocomplete",
		"class",
		"contenteditable",
		"dir",
		"disabled",
		"draggable",
		"form",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"multiple",
		"name",
		"required",
		"role",
		"size",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"title",
		"translate",
	];
}
