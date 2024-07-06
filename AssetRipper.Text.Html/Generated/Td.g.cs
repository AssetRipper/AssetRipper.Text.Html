// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Td : IHtmlElement<Td>,
	IAlignAttribute<Td>,
	IBackgroundAttribute<Td>,
	IBgColorAttribute<Td>,
	IColSpanAttribute<Td>,
	IHeadersAttribute<Td>,
	IRowSpanAttribute<Td>,
	IGlobalAttributes<Td>
{
	private const string ElementName = "td";
	private readonly TextWriter writer;

	public Td(TextWriter writer)
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

	public Td WithAccessKey(string? value = null)
	{
		AccessKey = value;
		return this;
	}

	public string? Align
	{
		set
		{
			writer.Write(" align=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Td WithAlign(string? value = null)
	{
		Align = value;
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

	public Td WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
		return this;
	}

	public string? Background
	{
		set
		{
			writer.Write(" background=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Td WithBackground(string? value = null)
	{
		Background = value;
		return this;
	}

	public string? BgColor
	{
		set
		{
			writer.Write(" bgcolor=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Td WithBgColor(string? value = null)
	{
		BgColor = value;
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

	public Td WithClass(string? value = null)
	{
		Class = value;
		return this;
	}

	public string? ColSpan
	{
		set
		{
			writer.Write(" colspan=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Td WithColSpan(string? value = null)
	{
		ColSpan = value;
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

	public Td WithContentEditable(string? value = null)
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

	public Td WithDir(string? value = null)
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

	public Td WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? Headers
	{
		set
		{
			writer.Write(" headers=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Td WithHeaders(string? value = null)
	{
		Headers = value;
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

	public Td WithHidden(string? value = null)
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

	public Td WithId(string? value = null)
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

	public Td WithItemProp(string? value = null)
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

	public Td WithLang(string? value = null)
	{
		Lang = value;
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

	public Td WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? RowSpan
	{
		set
		{
			writer.Write(" rowspan=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Td WithRowSpan(string? value = null)
	{
		RowSpan = value;
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

	public Td WithSlot(string? value = null)
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

	public Td WithSpellCheck(string? value = null)
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

	public Td WithStyle(string? value = null)
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

	public Td WithTabIndex(string? value = null)
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

	public Td WithTitle(string? value = null)
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

	public Td WithTranslate(string? value = null)
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
	TextWriter IHtmlElement<Td>.Writer => writer;
	static Td IHtmlElement<Td>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Td>.IsVoidElement => false;
	static string IHtmlElement<Td>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Td>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"align",
		"autocapitalize",
		"background",
		"bgcolor",
		"class",
		"colspan",
		"contenteditable",
		"dir",
		"draggable",
		"headers",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"role",
		"rowspan",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"title",
		"translate",
	];
}
