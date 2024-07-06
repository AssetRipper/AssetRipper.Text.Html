// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Area : IHtmlElement<Area>,
	IAltAttribute<Area>,
	ICoordsAttribute<Area>,
	IDownloadAttribute<Area>,
	IHrefAttribute<Area>,
	IMediaAttribute<Area>,
	IPingAttribute<Area>,
	IReferrerPolicyAttribute<Area>,
	IRelAttribute<Area>,
	IShapeAttribute<Area>,
	ITargetAttribute<Area>,
	IGlobalAttributes<Area>
{
	private const string ElementName = "area";
	private readonly TextWriter writer;

	public Area(TextWriter writer)
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

	public Area WithAccessKey(string? value = null)
	{
		AccessKey = value;
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

	public Area WithAlt(string? value = null)
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

	public Area WithAutocapitalize(string? value = null)
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

	public Area WithClass(string? value = null)
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

	public Area WithContentEditable(string? value = null)
	{
		ContentEditable = value;
		return this;
	}

	public string? Coords
	{
		set
		{
			writer.Write(" coords=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Area WithCoords(string? value = null)
	{
		Coords = value;
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

	public Area WithDir(string? value = null)
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

	public Area WithDownload(string? value = null)
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

	public Area WithDraggable(string? value = null)
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

	public Area WithHidden(string? value = null)
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

	public Area WithHref(string? value = null)
	{
		Href = value;
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

	public Area WithId(string? value = null)
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

	public Area WithItemProp(string? value = null)
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

	public Area WithLang(string? value = null)
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

	public Area WithMedia(string? value = null)
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

	public Area WithPing(string? value = null)
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

	public Area WithReferrerPolicy(string? value = null)
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

	public Area WithRel(string? value = null)
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

	public Area WithRole(string? value = null)
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

	public Area WithShape(string? value = null)
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

	public Area WithSlot(string? value = null)
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

	public Area WithSpellCheck(string? value = null)
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

	public Area WithStyle(string? value = null)
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

	public Area WithTabIndex(string? value = null)
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

	public Area WithTarget(string? value = null)
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

	public Area WithTitle(string? value = null)
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

	public Area WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public void Close() => writer.Write("/>");

	HtmlElementCloser IHtmlElement<Area>.End() => throw new NotSupportedException();

	// IHtmlElement<TSelf> implementation
	TextWriter IHtmlElement<Area>.Writer => writer;
	static Area IHtmlElement<Area>.Create(TextWriter writer) => new(writer);
	static bool IHtmlElement<Area>.IsVoidElement => true;
	static string IHtmlElement<Area>.Name => ElementName;
	static ReadOnlySpan<string> IHtmlElement<Area>.SupportedAttributes => _supportedAttributes;
	private static readonly string[] _supportedAttributes =
	[
		"accesskey",
		"alt",
		"autocapitalize",
		"class",
		"contenteditable",
		"coords",
		"dir",
		"download",
		"draggable",
		"hidden",
		"href",
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
