// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Table : IHtmlElement<Table>,
	IAlignAttribute<Table>,
	IBackgroundAttribute<Table>,
	IBgColorAttribute<Table>,
	IBorderAttribute<Table>,
	ISummaryAttribute<Table>,
	IGlobalAttributes<Table>
{
	private const string ElementName = "table";
	private readonly TextWriter writer;

	public Table(TextWriter writer)
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

	public Table WithAccessKey(string? value = null)
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

	public Table WithAlign(string? value = null)
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

	public Table WithAutocapitalize(string? value = null)
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

	public Table WithBackground(string? value = null)
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

	public Table WithBgColor(string? value = null)
	{
		BgColor = value;
		return this;
	}

	public string? Border
	{
		set
		{
			writer.Write(" border=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Table WithBorder(string? value = null)
	{
		Border = value;
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

	public Table WithClass(string? value = null)
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

	public Table WithContentEditable(string? value = null)
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

	public Table WithDir(string? value = null)
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

	public Table WithDraggable(string? value = null)
	{
		Draggable = value;
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

	public Table WithHidden(string? value = null)
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

	public Table WithId(string? value = null)
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

	public Table WithItemProp(string? value = null)
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

	public Table WithLang(string? value = null)
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

	public Table WithRole(string? value = null)
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

	public Table WithSlot(string? value = null)
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

	public Table WithSpellCheck(string? value = null)
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

	public Table WithStyle(string? value = null)
	{
		Style = value;
		return this;
	}

	public string? Summary
	{
		set
		{
			writer.Write(" summary=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Table WithSummary(string? value = null)
	{
		Summary = value;
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

	public Table WithTabIndex(string? value = null)
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

	public Table WithTitle(string? value = null)
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

	public Table WithTranslate(string? value = null)
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
	TextWriter IHtmlElement<Table>.Writer => writer;
	static Table IHtmlElement<Table>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Table>.IsVoidElement => false;
	static string IHtmlElement<Table>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Table>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"align",
		"autocapitalize",
		"background",
		"bgcolor",
		"border",
		"class",
		"contenteditable",
		"dir",
		"draggable",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"role",
		"slot",
		"spellcheck",
		"style",
		"summary",
		"tabindex",
		"title",
		"translate",
	];
}
