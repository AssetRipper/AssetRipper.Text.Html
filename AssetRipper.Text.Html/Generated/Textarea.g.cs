// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Textarea
{
	private const string ElementName = "textarea";
	private readonly TextWriter writer;

	public Textarea(TextWriter writer)
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

	public Textarea WithAccesskey(string? value = null)
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

	public Textarea WithAutocapitalize(string? value = null)
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

	public Textarea WithAutocomplete(string? value = null)
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

	public Textarea WithClass(string? value = null)
	{
		Class = value;
		return this;
	}

	public string? Cols
	{
		set
		{
			writer.Write(" cols=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithCols(string? value = null)
	{
		Cols = value;
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

	public Textarea WithContenteditable(string? value = null)
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

	public Textarea WithContextmenu(string? value = null)
	{
		Contextmenu = value;
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

	public Textarea WithDir(string? value = null)
	{
		Dir = value;
		return this;
	}

	public string? Dirname
	{
		set
		{
			writer.Write(" dirname=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithDirname(string? value = null)
	{
		Dirname = value;
		return this;
	}

	public string? Disabled
	{
		set
		{
			writer.Write(" disabled=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithDisabled(string? value = null)
	{
		Disabled = value;
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

	public Textarea WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? Enterkeyhint
	{
		set
		{
			writer.Write(" enterkeyhint=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithEnterkeyhint(string? value = null)
	{
		Enterkeyhint = value;
		return this;
	}

	public string? Form
	{
		set
		{
			writer.Write(" form=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithForm(string? value = null)
	{
		Form = value;
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

	public Textarea WithHidden(string? value = null)
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

	public Textarea WithId(string? value = null)
	{
		Id = value;
		return this;
	}

	public string? Inputmode
	{
		set
		{
			writer.Write(" inputmode=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithInputmode(string? value = null)
	{
		Inputmode = value;
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

	public Textarea WithItemprop(string? value = null)
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

	public Textarea WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Maxlength
	{
		set
		{
			writer.Write(" maxlength=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithMaxlength(string? value = null)
	{
		Maxlength = value;
		return this;
	}

	public string? Minlength
	{
		set
		{
			writer.Write(" minlength=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithMinlength(string? value = null)
	{
		Minlength = value;
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

	public Textarea WithName(string? value = null)
	{
		Name = value;
		return this;
	}

	public string? Placeholder
	{
		set
		{
			writer.Write(" placeholder=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithPlaceholder(string? value = null)
	{
		Placeholder = value;
		return this;
	}

	public string? Readonly
	{
		set
		{
			writer.Write(" readonly=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithReadonly(string? value = null)
	{
		Readonly = value;
		return this;
	}

	public string? Required
	{
		set
		{
			writer.Write(" required=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithRequired(string? value = null)
	{
		Required = value;
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

	public Textarea WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Rows
	{
		set
		{
			writer.Write(" rows=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithRows(string? value = null)
	{
		Rows = value;
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

	public Textarea WithSlot(string? value = null)
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

	public Textarea WithSpellcheck(string? value = null)
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

	public Textarea WithStyle(string? value = null)
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

	public Textarea WithTabindex(string? value = null)
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

	public Textarea WithTitle(string? value = null)
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

	public Textarea WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public string? Wrap
	{
		set
		{
			writer.Write(" wrap=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Textarea WithWrap(string? value = null)
	{
		Wrap = value;
		return this;
	}

	public Textarea WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Textarea WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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

	public HtmlElementCloser End()
	{
		writer.Write('>');
		return new HtmlElementCloser(writer, $"</{ElementName}>");
	}
}
