// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct U : IHtmlElement<U>,
	IGlobalAttributes<U>
{
	private const string ElementName = "u";
	private readonly TextWriter writer;

	public U(TextWriter writer)
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

	public U WithAccessKey(string? value = null)
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

	public U WithAutocapitalize(string? value = null)
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

	public U WithClass(string? value = null)
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

	public U WithContentEditable(string? value = null)
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

	public U WithDir(string? value = null)
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

	public U WithDraggable(string? value = null)
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

	public U WithHidden(string? value = null)
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

	public U WithId(string? value = null)
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

	public U WithItemProp(string? value = null)
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

	public U WithLang(string? value = null)
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

	public U WithRole(string? value = null)
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

	public U WithSlot(string? value = null)
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

	public U WithSpellCheck(string? value = null)
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

	public U WithStyle(string? value = null)
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

	public U WithTabIndex(string? value = null)
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

	public U WithTitle(string? value = null)
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

	public U WithTranslate(string? value = null)
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
	TextWriter IHtmlElement<U>.Writer => writer;
	static U IHtmlElement<U>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<U>.IsVoidElement => false;
	static string IHtmlElement<U>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<U>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
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
		"tabindex",
		"title",
		"translate",
	];
}
