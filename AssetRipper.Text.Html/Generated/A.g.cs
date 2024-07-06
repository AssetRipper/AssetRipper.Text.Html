// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct A : IHtmlElement<A>,
	IDownloadAttribute<A>,
	IHrefAttribute<A>,
	IHrefLangAttribute<A>,
	IMediaAttribute<A>,
	IPingAttribute<A>,
	IReferrerPolicyAttribute<A>,
	IRelAttribute<A>,
	IShapeAttribute<A>,
	ITargetAttribute<A>,
	IGlobalAttributes<A>
{
	private const string ElementName = "a";
	private readonly TextWriter writer;

	public A(TextWriter writer)
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

	public A WithAccessKey(string? value = null)
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

	public A WithAutocapitalize(string? value = null)
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

	public A WithClass(string? value = null)
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

	public A WithContentEditable(string? value = null)
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

	public A WithDir(string? value = null)
	{
		Dir = value;
		return this;
	}

	public string? Download
	{
		set
		{
			writer.Write(" download=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public A WithDownload(string? value = null)
	{
		Download = value;
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

	public A WithDraggable(string? value = null)
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

	public A WithHidden(string? value = null)
	{
		Hidden = value;
		return this;
	}

	public string? Href
	{
		set
		{
			writer.Write(" href=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public A WithHref(string? value = null)
	{
		Href = value;
		return this;
	}

	public string? HrefLang
	{
		set
		{
			writer.Write(" hreflang=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public A WithHrefLang(string? value = null)
	{
		HrefLang = value;
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

	public A WithId(string? value = null)
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

	public A WithItemProp(string? value = null)
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

	public A WithLang(string? value = null)
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

	public A WithMedia(string? value = null)
	{
		Media = value;
		return this;
	}

	public string? Ping
	{
		set
		{
			writer.Write(" ping=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public A WithPing(string? value = null)
	{
		Ping = value;
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

	public A WithReferrerPolicy(string? value = null)
	{
		ReferrerPolicy = value;
		return this;
	}

	public string? Rel
	{
		set
		{
			writer.Write(" rel=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public A WithRel(string? value = null)
	{
		Rel = value;
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

	public A WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Shape
	{
		set
		{
			writer.Write(" shape=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public A WithShape(string? value = null)
	{
		Shape = value;
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

	public A WithSlot(string? value = null)
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

	public A WithSpellCheck(string? value = null)
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

	public A WithStyle(string? value = null)
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

	public A WithTabIndex(string? value = null)
	{
		TabIndex = value;
		return this;
	}

	public string? Target
	{
		set
		{
			writer.Write(" target=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public A WithTarget(string? value = null)
	{
		Target = value;
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

	public A WithTitle(string? value = null)
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

	public A WithTranslate(string? value = null)
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
	TextWriter IHtmlElement<A>.Writer => writer;
	static A IHtmlElement<A>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<A>.IsVoidElement => false;
	static string IHtmlElement<A>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<A>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"autocapitalize",
		"class",
		"contenteditable",
		"dir",
		"download",
		"draggable",
		"hidden",
		"href",
		"hreflang",
		"id",
		"itemprop",
		"lang",
		"media",
		"ping",
		"referrerpolicy",
		"rel",
		"role",
		"shape",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"target",
		"title",
		"translate",
	];
}
