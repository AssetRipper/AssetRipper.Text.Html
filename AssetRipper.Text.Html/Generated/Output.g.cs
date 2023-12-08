// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Output
{
	private const string ElementName = "output";
	private readonly TextWriter writer;

	public Output(TextWriter writer)
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

	public Output WithAccesskey(string? value = null)
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

	public Output WithAutocapitalize(string? value = null)
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

	public Output WithClass(string? value = null)
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

	public Output WithContenteditable(string? value = null)
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

	public Output WithContextmenu(string? value = null)
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

	public Output WithDir(string? value = null)
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

	public Output WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? For
	{
		set
		{
			writer.Write(" for=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Output WithFor(string? value = null)
	{
		For = value;
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

	public Output WithForm(string? value = null)
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

	public Output WithHidden(string? value = null)
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

	public Output WithId(string? value = null)
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

	public Output WithItemprop(string? value = null)
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

	public Output WithLang(string? value = null)
	{
		Lang = value;
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

	public Output WithName(string? value = null)
	{
		Name = value;
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

	public Output WithRole(string? value = null)
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

	public Output WithSlot(string? value = null)
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

	public Output WithSpellcheck(string? value = null)
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

	public Output WithStyle(string? value = null)
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

	public Output WithTabindex(string? value = null)
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

	public Output WithTitle(string? value = null)
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

	public Output WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public Output WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Output WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
