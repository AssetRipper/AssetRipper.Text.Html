// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Video : IHtmlElement<Video>,
	IAutoplayAttribute<Video>,
	IControlsAttribute<Video>,
	ICrossOriginAttribute<Video>,
	IHeightAttribute<Video>,
	ILoopAttribute<Video>,
	IMutedAttribute<Video>,
	IPlaysInlineAttribute<Video>,
	IPosterAttribute<Video>,
	IPreloadAttribute<Video>,
	ISrcAttribute<Video>,
	IWidthAttribute<Video>,
	IGlobalAttributes<Video>
{
	private const string ElementName = "video";
	private readonly TextWriter writer;

	public Video(TextWriter writer)
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

	public Video WithAccessKey(string? value = null)
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

	public Video WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
		return this;
	}

	public string? Autoplay
	{
		set
		{
			writer.Write(" autoplay=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithAutoplay(string? value = null)
	{
		Autoplay = value;
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

	public Video WithClass(string? value = null)
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

	public Video WithContentEditable(string? value = null)
	{
		ContentEditable = value;
		return this;
	}

	public string? Controls
	{
		set
		{
			writer.Write(" controls=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithControls(string? value = null)
	{
		Controls = value;
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

	public Video WithCrossOrigin(string? value = null)
	{
		CrossOrigin = value;
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

	public Video WithDir(string? value = null)
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

	public Video WithDraggable(string? value = null)
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

	public Video WithHeight(string? value = null)
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

	public Video WithHidden(string? value = null)
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

	public Video WithId(string? value = null)
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

	public Video WithItemProp(string? value = null)
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

	public Video WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Loop
	{
		set
		{
			writer.Write(" loop=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithLoop(string? value = null)
	{
		Loop = value;
		return this;
	}

	public string? Muted
	{
		set
		{
			writer.Write(" muted=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithMuted(string? value = null)
	{
		Muted = value;
		return this;
	}

	public string? PlaysInline
	{
		set
		{
			writer.Write(" playsinline=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithPlaysInline(string? value = null)
	{
		PlaysInline = value;
		return this;
	}

	public string? Poster
	{
		set
		{
			writer.Write(" poster=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithPoster(string? value = null)
	{
		Poster = value;
		return this;
	}

	public string? Preload
	{
		set
		{
			writer.Write(" preload=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithPreload(string? value = null)
	{
		Preload = value;
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

	public Video WithRole(string? value = null)
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

	public Video WithSlot(string? value = null)
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

	public Video WithSpellCheck(string? value = null)
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

	public Video WithSrc(string? value = null)
	{
		Src = value;
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

	public Video WithStyle(string? value = null)
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

	public Video WithTabIndex(string? value = null)
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

	public Video WithTitle(string? value = null)
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

	public Video WithTranslate(string? value = null)
	{
		Translate = value;
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

	public Video WithWidth(string? value = null)
	{
		Width = value;
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
	TextWriter IHtmlElement<Video>.Writer => writer;
	static Video IHtmlElement<Video>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Video>.IsVoidElement => false;
	static string IHtmlElement<Video>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Video>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
		"autoplay",
		"class",
		"contenteditable",
		"controls",
		"crossorigin",
		"dir",
		"draggable",
		"height",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"loop",
		"muted",
		"playsinline",
		"poster",
		"preload",
		"role",
		"slot",
		"spellcheck",
		"src",
		"style",
		"tabindex",
		"title",
		"translate",
		"width",
	];
}
