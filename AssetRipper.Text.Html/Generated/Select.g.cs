// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Select
{
	private const string ElementName = "select";
	private readonly TextWriter writer;

	public Select(TextWriter writer)
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

	public Select WithAccesskey(string? value = null)
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

	public Select WithAutocapitalize(string? value = null)
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

	public Select WithAutocomplete(string? value = null)
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

	public Select WithClass(string? value = null)
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

	public Select WithContenteditable(string? value = null)
	{
		Contenteditable = value;
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

	public Select WithDir(string? value = null)
	{
		Dir = value;
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

	public Select WithDisabled(string? value = null)
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

	public Select WithDraggable(string? value = null)
	{
		Draggable = value;
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

	public Select WithForm(string? value = null)
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

	public Select WithHidden(string? value = null)
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

	public Select WithId(string? value = null)
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

	public Select WithItemprop(string? value = null)
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

	public Select WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Multiple
	{
		set
		{
			writer.Write(" multiple=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Select WithMultiple(string? value = null)
	{
		Multiple = value;
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

	public Select WithName(string? value = null)
	{
		Name = value;
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

	public Select WithRequired(string? value = null)
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

	public Select WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Size
	{
		set
		{
			writer.Write(" size=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Select WithSize(string? value = null)
	{
		Size = value;
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

	public Select WithSlot(string? value = null)
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

	public Select WithSpellcheck(string? value = null)
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

	public Select WithStyle(string? value = null)
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

	public Select WithTabindex(string? value = null)
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

	public Select WithTitle(string? value = null)
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

	public Select WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public Select WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Select WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
}
