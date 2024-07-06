// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Track
{
	private const string ElementName = "track";
	private readonly TextWriter writer;

	public Track(TextWriter writer)
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

	public Track WithAccesskey(string? value = null)
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

	public Track WithAutocapitalize(string? value = null)
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

	public Track WithClass(string? value = null)
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

	public Track WithContenteditable(string? value = null)
	{
		Contenteditable = value;
		return this;
	}

	public string? Default
	{
		set
		{
			writer.Write(" default=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Track WithDefault(string? value = null)
	{
		Default = value;
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

	public Track WithDir(string? value = null)
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

	public Track WithDraggable(string? value = null)
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

	public Track WithHidden(string? value = null)
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

	public Track WithId(string? value = null)
	{
		Id = value;
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

	public Track WithItemprop(string? value = null)
	{
		Itemprop = value;
		return this;
	}

	public string? Kind
	{
		set
		{
			writer.Write(" kind=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Track WithKind(string? value = null)
	{
		Kind = value;
		return this;
	}

	public string? Label
	{
		set
		{
			writer.Write(" label=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Track WithLabel(string? value = null)
	{
		Label = value;
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

	public Track WithLang(string? value = null)
	{
		Lang = value;
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

	public Track WithRole(string? value = null)
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

	public Track WithSlot(string? value = null)
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

	public Track WithSpellcheck(string? value = null)
	{
		Spellcheck = value;
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

	public Track WithSrc(string? value = null)
	{
		Src = value;
		return this;
	}

	public string? Srclang
	{
		set
		{
			writer.Write(" srclang=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Track WithSrclang(string? value = null)
	{
		Srclang = value;
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

	public Track WithStyle(string? value = null)
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

	public Track WithTabindex(string? value = null)
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

	public Track WithTitle(string? value = null)
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

	public Track WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public Track WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Track WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
