// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Source : IHtmlElement<Source>,
	IMediaAttribute<Source>,
	ISizesAttribute<Source>,
	ISrcAttribute<Source>,
	ISrcSetAttribute<Source>,
	ITypeAttribute<Source>,
	IGlobalAttributes<Source>
{
	private const string ElementName = "source";
	private readonly TextWriter writer;

	public Source(TextWriter writer)
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

	public Source WithAccessKey(string? value = null)
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

	public Source WithAutocapitalize(string? value = null)
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

	public Source WithClass(string? value = null)
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

	public Source WithContentEditable(string? value = null)
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

	public Source WithDir(string? value = null)
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

	public Source WithDraggable(string? value = null)
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

	public Source WithHidden(string? value = null)
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

	public Source WithId(string? value = null)
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

	public Source WithItemProp(string? value = null)
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

	public Source WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Media
	{
		set
		{
			writer.Write(" media=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Source WithMedia(string? value = null)
	{
		Media = value;
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

	public Source WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Sizes
	{
		set
		{
			writer.Write(" sizes=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Source WithSizes(string? value = null)
	{
		Sizes = value;
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

	public Source WithSlot(string? value = null)
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

	public Source WithSpellCheck(string? value = null)
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

	public Source WithSrc(string? value = null)
	{
		Src = value;
		return this;
	}

	public string? SrcSet
	{
		set
		{
			writer.Write(" srcset=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Source WithSrcSet(string? value = null)
	{
		SrcSet = value;
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

	public Source WithStyle(string? value = null)
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

	public Source WithTabIndex(string? value = null)
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

	public Source WithTitle(string? value = null)
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

	public Source WithTranslate(string? value = null)
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

	public Source WithType(string? value = null)
	{
		Type = value;
		return this;
	}

	public void Close() => writer.Write("/>");

	HtmlElementCloser IHtmlElement<Source>.End() => throw new NotSupportedException();

	// IHtmlElement<TSelf> implementation
	TextWriter IHtmlElement<Source>.Writer => writer;
	static Source IHtmlElement<Source>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Source>.IsVoidElement => true;
	static string IHtmlElement<Source>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Source>.SupportedAttributes => _supportedAttributes;
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
		"media",
		"role",
		"sizes",
		"slot",
		"spellcheck",
		"src",
		"srcset",
		"style",
		"tabindex",
		"title",
		"translate",
		"type",
	];
}
