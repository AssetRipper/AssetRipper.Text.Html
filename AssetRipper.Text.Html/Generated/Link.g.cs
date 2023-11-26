// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Link
{
	private const string ElementName = "link";
	private readonly TextWriter writer;

	public Link(TextWriter writer)
	{
		this.writer = writer;
		writer.Write($"<{ElementName}");
	}

	public string? Accesskey
	{
		set
		{
			writer.Write(" accesskey=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithAccesskey(string? value = null)
	{
		Accesskey = value;
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

	public string? Contenteditable
	{
		set
		{
			writer.Write(" contenteditable=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithContenteditable(string? value = null)
	{
		Contenteditable = value;
		return this;
	}

	public string? Contextmenu
	{
		set
		{
			writer.Write(" contextmenu=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithContextmenu(string? value = null)
	{
		Contextmenu = value;
		return this;
	}

	public string? Crossorigin
	{
		set
		{
			writer.Write(" crossorigin=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithCrossorigin(string? value = null)
	{
		Crossorigin = value;
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

	public string? Hreflang
	{
		set
		{
			writer.Write(" hreflang=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithHreflang(string? value = null)
	{
		Hreflang = value;
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

	public string? Itemprop
	{
		set
		{
			writer.Write(" itemprop=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithItemprop(string? value = null)
	{
		Itemprop = value;
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

	public string? Referrerpolicy
	{
		set
		{
			writer.Write(" referrerpolicy=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithReferrerpolicy(string? value = null)
	{
		Referrerpolicy = value;
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

	public string? Spellcheck
	{
		set
		{
			writer.Write(" spellcheck=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithSpellcheck(string? value = null)
	{
		Spellcheck = value;
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

	public string? Tabindex
	{
		set
		{
			writer.Write(" tabindex=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Link WithTabindex(string? value = null)
	{
		Tabindex = value;
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

	public Link WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Link WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
	{
		foreach ((string key, string? value) in attributes)
		{
			WriteKey(key);
			WriteValue(value);
		}
		return this;
	}

	private void WriteKey(string key)
	{
		writer.Write(' ');
		writer.Write(key);
	}

	private void WriteValue(string? value)
	{
		writer.Write("=\"");
		writer.Write(value);
		writer.Write('"');
	}

	public void Close() => writer.Write("/>");
}
