// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Th
{
	private const string ElementName = "th";
	private readonly TextWriter writer;

	public Th(TextWriter writer)
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

	public Th WithAccesskey(string? value = null)
	{
		Accesskey = value;
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

	public Th WithAlign(string? value = null)
	{
		Align = value;
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

	public Th WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
		return this;
	}

	public string? Background
	{
		set
		{
			writer.Write(" background=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Th WithBackground(string? value = null)
	{
		Background = value;
		return this;
	}

	public string? Bgcolor
	{
		set
		{
			writer.Write(" bgcolor=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Th WithBgcolor(string? value = null)
	{
		Bgcolor = value;
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

	public Th WithClass(string? value = null)
	{
		Class = value;
		return this;
	}

	public string? Colspan
	{
		set
		{
			writer.Write(" colspan=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Th WithColspan(string? value = null)
	{
		Colspan = value;
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

	public Th WithContenteditable(string? value = null)
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

	public Th WithDir(string? value = null)
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

	public Th WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? Headers
	{
		set
		{
			writer.Write(" headers=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Th WithHeaders(string? value = null)
	{
		Headers = value;
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

	public Th WithHidden(string? value = null)
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

	public Th WithId(string? value = null)
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

	public Th WithItemprop(string? value = null)
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

	public Th WithLang(string? value = null)
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

	public Th WithRole(string? value = null)
	{
		Role = value;
		return this;
	}

	public string? Rowspan
	{
		set
		{
			writer.Write(" rowspan=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Th WithRowspan(string? value = null)
	{
		Rowspan = value;
		return this;
	}

	public string? Scope
	{
		set
		{
			writer.Write(" scope=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Th WithScope(string? value = null)
	{
		Scope = value;
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

	public Th WithSlot(string? value = null)
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

	public Th WithSpellcheck(string? value = null)
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

	public Th WithStyle(string? value = null)
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

	public Th WithTabindex(string? value = null)
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

	public Th WithTitle(string? value = null)
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

	public Th WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public Th WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Th WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
