// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Iframe : IHtmlElement<Iframe>,
	IAlignAttribute<Iframe>,
	IAllowAttribute<Iframe>,
	ICspAttribute<Iframe>,
	IHeightAttribute<Iframe>,
	ILoadingAttribute<Iframe>,
	INameAttribute<Iframe>,
	IReferrerPolicyAttribute<Iframe>,
	ISandboxAttribute<Iframe>,
	ISrcAttribute<Iframe>,
	ISrcDocAttribute<Iframe>,
	IWidthAttribute<Iframe>,
	IGlobalAttributes<Iframe>
{
	private const string ElementName = "iframe";
	private readonly TextWriter writer;

	public Iframe(TextWriter writer)
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

	public Iframe WithAccessKey(string? value = null)
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

	public Iframe WithAlign(string? value = null)
	{
		Align = value;
		return this;
	}

	public string? Allow
	{
		set
		{
			writer.Write(" allow=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Iframe WithAllow(string? value = null)
	{
		Allow = value;
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

	public Iframe WithAutocapitalize(string? value = null)
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

	public Iframe WithClass(string? value = null)
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

	public Iframe WithContentEditable(string? value = null)
	{
		ContentEditable = value;
		return this;
	}

	public string? Csp
	{
		set
		{
			writer.Write(" csp=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Iframe WithCsp(string? value = null)
	{
		Csp = value;
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

	public Iframe WithDir(string? value = null)
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

	public Iframe WithDraggable(string? value = null)
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

	public Iframe WithHeight(string? value = null)
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

	public Iframe WithHidden(string? value = null)
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

	public Iframe WithId(string? value = null)
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

	public Iframe WithItemProp(string? value = null)
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

	public Iframe WithLang(string? value = null)
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

	public Iframe WithLoading(string? value = null)
	{
		Loading = value;
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

	public Iframe WithName(string? value = null)
	{
		Name = value;
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

	public Iframe WithReferrerPolicy(string? value = null)
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

	public Iframe WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Sandbox
	{
		set
		{
			writer.Write(" sandbox=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Iframe WithSandbox(string? value = null)
	{
		Sandbox = value;
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

	public Iframe WithSlot(string? value = null)
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

	public Iframe WithSpellCheck(string? value = null)
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

	public Iframe WithSrc(string? value = null)
	{
		Src = value;
		return this;
	}

	public string? SrcDoc
	{
		set
		{
			writer.Write(" srcdoc=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Iframe WithSrcDoc(string? value = null)
	{
		SrcDoc = value;
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

	public Iframe WithStyle(string? value = null)
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

	public Iframe WithTabIndex(string? value = null)
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

	public Iframe WithTitle(string? value = null)
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

	public Iframe WithTranslate(string? value = null)
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

	public Iframe WithWidth(string? value = null)
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
	TextWriter IHtmlElement<Iframe>.Writer => writer;
	static Iframe IHtmlElement<Iframe>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Iframe>.IsVoidElement => false;
	static string IHtmlElement<Iframe>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Iframe>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"align",
		"allow",
		"autocapitalize",
		"class",
		"contenteditable",
		"csp",
		"dir",
		"draggable",
		"height",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"loading",
		"name",
		"referrerpolicy",
		"role",
		"sandbox",
		"slot",
		"spellcheck",
		"src",
		"srcdoc",
		"style",
		"tabindex",
		"title",
		"translate",
		"width",
	];
}
