// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Audio : IHtmlElement<Audio>,
	IAutoplayAttribute<Audio>,
	IControlsAttribute<Audio>,
	ICrossOriginAttribute<Audio>,
	ILoopAttribute<Audio>,
	IMutedAttribute<Audio>,
	IPreloadAttribute<Audio>,
	ISrcAttribute<Audio>,
	IGlobalAttributes<Audio>
{
	private const string ElementName = "audio";
	private readonly TextWriter writer;

	public Audio(TextWriter writer)
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

	public Audio WithAccessKey(string? value = null)
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

	public Audio WithAutocapitalize(string? value = null)
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

	public Audio WithAutoplay(string? value = null)
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

	public Audio WithClass(string? value = null)
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

	public Audio WithContentEditable(string? value = null)
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

	public Audio WithControls(string? value = null)
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

	public Audio WithCrossOrigin(string? value = null)
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

	public Audio WithDir(string? value = null)
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

	public Audio WithDraggable(string? value = null)
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

	public Audio WithHidden(string? value = null)
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

	public Audio WithId(string? value = null)
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

	public Audio WithItemProp(string? value = null)
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

	public Audio WithLang(string? value = null)
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

	public Audio WithLoop(string? value = null)
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

	public Audio WithMuted(string? value = null)
	{
		Muted = value;
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

	public Audio WithPreload(string? value = null)
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

	public Audio WithRole(string? value = null)
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

	public Audio WithSlot(string? value = null)
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

	public Audio WithSpellCheck(string? value = null)
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

	public Audio WithSrc(string? value = null)
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

	public Audio WithStyle(string? value = null)
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

	public Audio WithTabIndex(string? value = null)
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

	public Audio WithTitle(string? value = null)
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

	public Audio WithTranslate(string? value = null)
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
	TextWriter IHtmlElement<Audio>.Writer => writer;
	static Audio IHtmlElement<Audio>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Audio>.IsVoidElement => false;
	static string IHtmlElement<Audio>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Audio>.SupportedAttributes => _supportedAttributes;
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
		"hidden",
		"id",
		"itemprop",
		"lang",
		"loop",
		"muted",
		"preload",
		"role",
		"slot",
		"spellcheck",
		"src",
		"style",
		"tabindex",
		"title",
		"translate",
	];
}
