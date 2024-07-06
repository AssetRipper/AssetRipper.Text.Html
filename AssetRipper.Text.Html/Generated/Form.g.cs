// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Form : IHtmlElement<Form>,
	IAcceptAttribute<Form>,
	IAcceptCharsetAttribute<Form>,
	IActionAttribute<Form>,
	IAutocompleteAttribute<Form>,
	IEnctypeAttribute<Form>,
	IMethodAttribute<Form>,
	INameAttribute<Form>,
	INovalidateAttribute<Form>,
	ITargetAttribute<Form>,
	IGlobalAttributes<Form>
{
	private const string ElementName = "form";
	private readonly TextWriter writer;

	public Form(TextWriter writer)
	{
		this.writer = writer;
		writer.Write($"<{ElementName}");
	}

	public string? Accept
	{
		set
		{
			writer.Write(" accept=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Form WithAccept(string? value = null)
	{
		Accept = value;
		return this;
	}

	public string? AcceptCharset
	{
		set
		{
			writer.Write(" accept-charset=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Form WithAcceptCharset(string? value = null)
	{
		AcceptCharset = value;
		return this;
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

	public Form WithAccessKey(string? value = null)
	{
		AccessKey = value;
		return this;
	}

	public string? Action
	{
		set
		{
			writer.Write(" action=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Form WithAction(string? value = null)
	{
		Action = value;
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

	public Form WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
		return this;
	}

	public string? Autocomplete
	{
		set
		{
			writer.Write(" autocomplete=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Form WithAutocomplete(string? value = null)
	{
		Autocomplete = value;
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

	public Form WithClass(string? value = null)
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

	public Form WithContentEditable(string? value = null)
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

	public Form WithDir(string? value = null)
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

	public Form WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? Enctype
	{
		set
		{
			writer.Write(" enctype=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Form WithEnctype(string? value = null)
	{
		Enctype = value;
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

	public Form WithHidden(string? value = null)
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

	public Form WithId(string? value = null)
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

	public Form WithItemProp(string? value = null)
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

	public Form WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Method
	{
		set
		{
			writer.Write(" method=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Form WithMethod(string? value = null)
	{
		Method = value;
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

	public Form WithName(string? value = null)
	{
		Name = value;
		return this;
	}

	public string? Novalidate
	{
		set
		{
			writer.Write(" novalidate=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Form WithNovalidate(string? value = null)
	{
		Novalidate = value;
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

	public Form WithRole(string? value = null)
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

	public Form WithSlot(string? value = null)
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

	public Form WithSpellCheck(string? value = null)
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

	public Form WithStyle(string? value = null)
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

	public Form WithTabIndex(string? value = null)
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

	public Form WithTarget(string? value = null)
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

	public Form WithTitle(string? value = null)
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

	public Form WithTranslate(string? value = null)
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
	TextWriter IHtmlElement<Form>.Writer => writer;
	static Form IHtmlElement<Form>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Form>.IsVoidElement => false;
	static string IHtmlElement<Form>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Form>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accept",
		"accept-charset",
		"accesskey",
		"action",
		"autocapitalize",
		"autocomplete",
		"class",
		"contenteditable",
		"dir",
		"draggable",
		"enctype",
		"hidden",
		"id",
		"itemprop",
		"lang",
		"method",
		"name",
		"novalidate",
		"role",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"target",
		"title",
		"translate",
	];
}
