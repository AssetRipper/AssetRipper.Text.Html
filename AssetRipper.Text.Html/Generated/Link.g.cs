// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Link : IHtmlElement<Link>,
	IAsAttribute<Link>,
	ICrossOriginAttribute<Link>,
	IHrefAttribute<Link>,
	IHrefLangAttribute<Link>,
	IIntegrityAttribute<Link>,
	IMediaAttribute<Link>,
	IReferrerPolicyAttribute<Link>,
	IRelAttribute<Link>,
	ISizesAttribute<Link>,
	ITypeAttribute<Link>,
	IGlobalAttributes<Link>
{
	private const string ElementName = "link";
	private readonly TextWriter writer;

	public Link(TextWriter writer)
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

	public Link WithAccessKey(string? value = null)
	{
		AccessKey = value;
		return this;
	}

	public string? As
	{
		set
		{
			writer.Write(" as=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithAs(string? value = null)
	{
		As = value;
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

	public Link WithAutocapitalize(string? value = null)
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

	public Link WithClass(string? value = null)
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

	public Link WithContentEditable(string? value = null)
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

	public Link WithCrossOrigin(string? value = null)
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

	public Link WithDir(string? value = null)
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

	public Link WithDraggable(string? value = null)
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

	public Link WithHidden(string? value = null)
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

	public Link WithHref(string? value = null)
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

	public Link WithHrefLang(string? value = null)
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

	public Link WithId(string? value = null)
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

	public Link WithIntegrity(string? value = null)
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

	public Link WithItemProp(string? value = null)
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

	public Link WithLang(string? value = null)
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

	public Link WithMedia(string? value = null)
	{
		Media = value;
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

	public Link WithReferrerPolicy(string? value = null)
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

	public Link WithRel(string? value = null)
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

	public Link WithRole(string? value = null)
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

	public Link WithSizes(string? value = null)
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

	public Link WithSlot(string? value = null)
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

	public Link WithSpellCheck(string? value = null)
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

	public Link WithStyle(string? value = null)
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

	public Link WithTabIndex(string? value = null)
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

	public Link WithTitle(string? value = null)
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

	public Link WithTranslate(string? value = null)
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

	public Link WithType(string? value = null)
	{
		Type = value;
		return this;
	}

	public void Close() => writer.Write("/>");

	HtmlElementCloser IHtmlElement<Link>.End() => throw new NotSupportedException();

	// IHtmlElement<TSelf> implementation
	TextWriter IHtmlElement<Link>.Writer => writer;
	static Link IHtmlElement<Link>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Link>.IsVoidElement => true;
	static string IHtmlElement<Link>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Link>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"as",
		"autocapitalize",
		"class",
		"contenteditable",
		"crossorigin",
		"dir",
		"draggable",
		"hidden",
		"href",
		"hreflang",
		"id",
		"integrity",
		"itemprop",
		"lang",
		"media",
		"referrerpolicy",
		"rel",
		"role",
		"sizes",
		"slot",
		"spellcheck",
		"style",
		"tabindex",
		"title",
		"translate",
		"type",
	];
}
