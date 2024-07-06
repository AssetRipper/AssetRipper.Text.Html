// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Script : IHtmlElement<Script>,
	IAsyncAttribute<Script>,
	ICrossOriginAttribute<Script>,
	IDeferAttribute<Script>,
	IIntegrityAttribute<Script>,
	ILanguageAttribute<Script>,
	IReferrerPolicyAttribute<Script>,
	ISrcAttribute<Script>,
	ITypeAttribute<Script>,
	IGlobalAttributes<Script>
{
	private const string ElementName = "script";
	private readonly TextWriter writer;

	public Script(TextWriter writer)
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

	public Script WithAccessKey(string? value = null)
	{
		AccessKey = value;
		return this;
	}

	public string? Async
	{
		set
		{
			writer.Write(" async=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Script WithAsync(string? value = null)
	{
		Async = value;
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

	public Script WithAutocapitalize(string? value = null)
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

	public Script WithClass(string? value = null)
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

	public Script WithContentEditable(string? value = null)
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

	public Script WithCrossOrigin(string? value = null)
	{
		CrossOrigin = value;
		return this;
	}

	public string? Defer
	{
		set
		{
			writer.Write(" defer=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Script WithDefer(string? value = null)
	{
		Defer = value;
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

	public Script WithDir(string? value = null)
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

	public Script WithDraggable(string? value = null)
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

	public Script WithHidden(string? value = null)
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

	public Script WithId(string? value = null)
	{
		Id = value;
		return this;
	}

	public string? Integrity
	{
		set
		{
			writer.Write(" integrity=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Script WithIntegrity(string? value = null)
	{
		Integrity = value;
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

	public Script WithItemProp(string? value = null)
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

	public Script WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Language
	{
		set
		{
			writer.Write(" language=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Script WithLanguage(string? value = null)
	{
		Language = value;
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

	public Script WithReferrerPolicy(string? value = null)
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

	public Script WithRole(string? value = null)
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

	public Script WithSlot(string? value = null)
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

	public Script WithSpellCheck(string? value = null)
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

	public Script WithSrc(string? value = null)
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

	public Script WithStyle(string? value = null)
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

	public Script WithTabIndex(string? value = null)
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

	public Script WithTitle(string? value = null)
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

	public Script WithTranslate(string? value = null)
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

	public Script WithType(string? value = null)
	{
		Type = value;
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
	TextWriter IHtmlElement<Script>.Writer => writer;
	static Script IHtmlElement<Script>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Script>.IsVoidElement => false;
	static string IHtmlElement<Script>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Script>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"async",
		"autocapitalize",
		"class",
		"contenteditable",
		"crossorigin",
		"defer",
		"dir",
		"draggable",
		"hidden",
		"id",
		"integrity",
		"itemprop",
		"lang",
		"language",
		"referrerpolicy",
		"role",
		"slot",
		"spellcheck",
		"src",
		"style",
		"tabindex",
		"title",
		"translate",
		"type",
	];
}
