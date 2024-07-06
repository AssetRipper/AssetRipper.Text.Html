// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Th : IHtmlElement<Th>,
	IAlignAttribute<Th>,
	IBackgroundAttribute<Th>,
	IBgColorAttribute<Th>,
	IColSpanAttribute<Th>,
	IHeadersAttribute<Th>,
	IRowSpanAttribute<Th>,
	IScopeAttribute<Th>,
	IGlobalAttributes<Th>
{
	private const string ElementName = "th";
	private readonly TextWriter writer;

	public Th(TextWriter writer)
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

	public Th WithAccessKey(string? value = null)
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

	public Th WithAlign(string? value = null)
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

	public Th WithAutocapitalize(string? value = null)
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

	public Th WithBackground(string? value = null)
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

	public Th WithBgColor(string? value = null)
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

	public Th WithClass(string? value = null)
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

	public Th WithColSpan(string? value = null)
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

	public Th WithContentEditable(string? value = null)
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

	public Th WithDir(string? value = null)
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

	public Th WithDraggable(string? value = null)
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

	public Th WithHeaders(string? value = null)
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

	public Th WithHidden(string? value = null)
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

	public Th WithId(string? value = null)
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

	public Th WithItemProp(string? value = null)
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

	public Th WithLang(string? value = null)
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

	public Th WithRole(string? value = null)
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

	public Th WithRowSpan(string? value = null)
	{
		RowSpan = value;
		return this;
	}

	public string? Scope
	{
		set
		{
			writer.Write(" scope=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Th WithScope(string? value = null)
	{
		Scope = value;
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

	public Th WithSlot(string? value = null)
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

	public Th WithSpellCheck(string? value = null)
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

	public Th WithStyle(string? value = null)
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

	public Th WithTabIndex(string? value = null)
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

	public Th WithTitle(string? value = null)
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

	public Th WithTranslate(string? value = null)
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
	TextWriter IHtmlElement<Th>.Writer => writer;
	static Th IHtmlElement<Th>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Th>.IsVoidElement => false;
	static string IHtmlElement<Th>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Th>.SupportedAttributes => _supportedAttributes;
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
		"scope",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"title",
		"translate",
	];
}
