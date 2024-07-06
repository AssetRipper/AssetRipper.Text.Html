// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Meter : IHtmlElement<Meter>,
	IFormAttribute<Meter>,
	IHighAttribute<Meter>,
	ILowAttribute<Meter>,
	IMaxAttribute<Meter>,
	IMinAttribute<Meter>,
	IOptimumAttribute<Meter>,
	IValueAttribute<Meter>,
	IGlobalAttributes<Meter>
{
	private const string ElementName = "meter";
	private readonly TextWriter writer;

	public Meter(TextWriter writer)
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

	public Meter WithAccessKey(string? value = null)
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

	public Meter WithAutocapitalize(string? value = null)
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

	public Meter WithClass(string? value = null)
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

	public Meter WithContentEditable(string? value = null)
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

	public Meter WithDir(string? value = null)
	{
		Dir = value;
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

	public Meter WithDraggable(string? value = null)
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

	public Meter WithForm(string? value = null)
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

	public Meter WithHidden(string? value = null)
	{
		Hidden = value;
		return this;
	}

	public string? High
	{
		set
		{
			writer.Write(" high=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Meter WithHigh(string? value = null)
	{
		High = value;
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

	public Meter WithId(string? value = null)
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

	public Meter WithItemProp(string? value = null)
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

	public Meter WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Low
	{
		set
		{
			writer.Write(" low=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Meter WithLow(string? value = null)
	{
		Low = value;
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

	public Meter WithMax(string? value = null)
	{
		Max = value;
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

	public Meter WithMin(string? value = null)
	{
		Min = value;
		return this;
	}

	public string? Optimum
	{
		set
		{
			writer.Write(" optimum=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Meter WithOptimum(string? value = null)
	{
		Optimum = value;
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

	public Meter WithRole(string? value = null)
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

	public Meter WithSlot(string? value = null)
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

	public Meter WithSpellCheck(string? value = null)
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

	public Meter WithStyle(string? value = null)
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

	public Meter WithTabIndex(string? value = null)
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

	public Meter WithTitle(string? value = null)
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

	public Meter WithTranslate(string? value = null)
	{
		Translate = value;
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

	public Meter WithValue(string? value = null)
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
	TextWriter IHtmlElement<Meter>.Writer => writer;
	static Meter IHtmlElement<Meter>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Meter>.IsVoidElement => false;
	static string IHtmlElement<Meter>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Meter>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
		"class",
		"contenteditable",
		"dir",
		"draggable",
		"form",
		"hidden",
		"high",
		"id",
		"itemprop",
		"lang",
		"low",
		"max",
		"min",
		"optimum",
		"role",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"title",
		"translate",
		"value",
	];
}
