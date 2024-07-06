// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Meta : IHtmlElement<Meta>,
	ICharsetAttribute<Meta>,
	IContentAttribute<Meta>,
	IHttpEquivAttribute<Meta>,
	INameAttribute<Meta>,
	IGlobalAttributes<Meta>
{
	private const string ElementName = "meta";
	private readonly TextWriter writer;

	public Meta(TextWriter writer)
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

	public Meta WithAccessKey(string? value = null)
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

	public Meta WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
		return this;
	}

	public string? Charset
	{
		set
		{
			writer.Write(" charset=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Meta WithCharset(string? value = null)
	{
		Charset = value;
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

	public Meta WithClass(string? value = null)
	{
		Class = value;
		return this;
	}

	public string? Content
	{
		set
		{
			writer.Write(" content=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Meta WithContent(string? value = null)
	{
		Content = value;
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

	public Meta WithContentEditable(string? value = null)
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

	public Meta WithDir(string? value = null)
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

	public Meta WithDraggable(string? value = null)
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

	public Meta WithHidden(string? value = null)
	{
		Hidden = value;
		return this;
	}

	public string? HttpEquiv
	{
		set
		{
			writer.Write(" http-equiv=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Meta WithHttpEquiv(string? value = null)
	{
		HttpEquiv = value;
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

	public Meta WithId(string? value = null)
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

	public Meta WithItemProp(string? value = null)
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

	public Meta WithLang(string? value = null)
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

	public Meta WithName(string? value = null)
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

	public Meta WithRole(string? value = null)
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

	public Meta WithSlot(string? value = null)
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

	public Meta WithSpellCheck(string? value = null)
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

	public Meta WithStyle(string? value = null)
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

	public Meta WithTabIndex(string? value = null)
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

	public Meta WithTitle(string? value = null)
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

	public Meta WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public void Close() => writer.Write("/>");

	HtmlElementCloser IHtmlElement<Meta>.End() => throw new NotSupportedException();

	// IHtmlElement<TSelf> implementation
	TextWriter IHtmlElement<Meta>.Writer => writer;
	static Meta IHtmlElement<Meta>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Meta>.IsVoidElement => true;
	static string IHtmlElement<Meta>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Meta>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
		"charset",
		"class",
		"content",
		"contenteditable",
		"dir",
		"draggable",
		"hidden",
		"http-equiv",
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
	];
}
