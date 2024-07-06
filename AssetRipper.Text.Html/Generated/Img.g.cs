// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Img : IHtmlElement<Img>,
	IAlignAttribute<Img>,
	IAltAttribute<Img>,
	IBorderAttribute<Img>,
	ICrossOriginAttribute<Img>,
	IDecodingAttribute<Img>,
	IHeightAttribute<Img>,
	IIntrinsicsizeAttribute<Img>,
	IIsMapAttribute<Img>,
	ILoadingAttribute<Img>,
	IReferrerPolicyAttribute<Img>,
	ISizesAttribute<Img>,
	ISrcAttribute<Img>,
	ISrcSetAttribute<Img>,
	IUseMapAttribute<Img>,
	IWidthAttribute<Img>,
	IGlobalAttributes<Img>
{
	private const string ElementName = "img";
	private readonly TextWriter writer;

	public Img(TextWriter writer)
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

	public Img WithAccessKey(string? value = null)
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

	public Img WithAlign(string? value = null)
	{
		Align = value;
		return this;
	}

	public string? Alt
	{
		set
		{
			writer.Write(" alt=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithAlt(string? value = null)
	{
		Alt = value;
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

	public Img WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
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

	public Img WithBorder(string? value = null)
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

	public Img WithClass(string? value = null)
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

	public Img WithContentEditable(string? value = null)
	{
		ContentEditable = value;
		return this;
	}

	public string? CrossOrigin
	{
		set
		{
			writer.Write(" crossorigin=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithCrossOrigin(string? value = null)
	{
		CrossOrigin = value;
		return this;
	}

	public string? Decoding
	{
		set
		{
			writer.Write(" decoding=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithDecoding(string? value = null)
	{
		Decoding = value;
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

	public Img WithDir(string? value = null)
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

	public Img WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? Height
	{
		set
		{
			writer.Write(" height=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithHeight(string? value = null)
	{
		Height = value;
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

	public Img WithHidden(string? value = null)
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

	public Img WithId(string? value = null)
	{
		Id = value;
		return this;
	}

	public string? Intrinsicsize
	{
		set
		{
			writer.Write(" intrinsicsize=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithIntrinsicsize(string? value = null)
	{
		Intrinsicsize = value;
		return this;
	}

	public string? IsMap
	{
		set
		{
			writer.Write(" ismap=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithIsMap(string? value = null)
	{
		IsMap = value;
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

	public Img WithItemProp(string? value = null)
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

	public Img WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Loading
	{
		set
		{
			writer.Write(" loading=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithLoading(string? value = null)
	{
		Loading = value;
		return this;
	}

	public string? ReferrerPolicy
	{
		set
		{
			writer.Write(" referrerpolicy=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithReferrerPolicy(string? value = null)
	{
		ReferrerPolicy = value;
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

	public Img WithRole(string? value = null)
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

	public Img WithSizes(string? value = null)
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

	public Img WithSlot(string? value = null)
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

	public Img WithSpellCheck(string? value = null)
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

	public Img WithSrc(string? value = null)
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

	public Img WithSrcSet(string? value = null)
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

	public Img WithStyle(string? value = null)
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

	public Img WithTabIndex(string? value = null)
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

	public Img WithTitle(string? value = null)
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

	public Img WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public string? UseMap
	{
		set
		{
			writer.Write(" usemap=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithUseMap(string? value = null)
	{
		UseMap = value;
		return this;
	}

	public string? Width
	{
		set
		{
			writer.Write(" width=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Img WithWidth(string? value = null)
	{
		Width = value;
		return this;
	}

	public void Close() => writer.Write("/>");

	HtmlElementCloser IHtmlElement<Img>.End() => throw new NotSupportedException();

	// IHtmlElement<TSelf> implementation
	TextWriter IHtmlElement<Img>.Writer => writer;
	static Img IHtmlElement<Img>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Img>.IsVoidElement => true;
	static string IHtmlElement<Img>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Img>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"align",
		"alt",
		"autocapitalize",
		"border",
		"class",
		"contenteditable",
		"crossorigin",
		"decoding",
		"dir",
		"draggable",
		"height",
		"hidden",
		"id",
		"intrinsicsize",
		"ismap",
		"itemprop",
		"lang",
		"loading",
		"referrerpolicy",
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
		"usemap",
		"width",
	];
}
