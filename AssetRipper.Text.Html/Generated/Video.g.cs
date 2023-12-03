// Auto-generated code. Do not modify manually.

#nullable enable

namespace AssetRipper.Text.Html;

public readonly ref partial struct Video
{
	private const string ElementName = "video";
	private readonly TextWriter writer;

	public Video(TextWriter writer)
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

	public Video WithAccesskey(string? value = null)
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

	public Video WithAutocapitalize(string? value = null)
	{
		Autocapitalize = value;
		return this;
	}

	public string? Autoplay
	{
		set
		{
			writer.Write(" autoplay=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithAutoplay(string? value = null)
	{
		Autoplay = value;
		return this;
	}

	public string? Buffered
	{
		set
		{
			writer.Write(" buffered=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithBuffered(string? value = null)
	{
		Buffered = value;
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

	public Video WithClass(string? value = null)
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

	public Video WithContenteditable(string? value = null)
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

	public Video WithContextmenu(string? value = null)
	{
		Contextmenu = value;
		return this;
	}

	public string? Controls
	{
		set
		{
			writer.Write(" controls=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithControls(string? value = null)
	{
		Controls = value;
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

	public Video WithCrossorigin(string? value = null)
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

	public Video WithDir(string? value = null)
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

	public Video WithDraggable(string? value = null)
	{
		Draggable = value;
		return this;
	}

	public string? Height
	{
		set
		{
			writer.Write(" height=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithHeight(string? value = null)
	{
		Height = value;
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

	public Video WithHidden(string? value = null)
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

	public Video WithId(string? value = null)
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

	public Video WithItemprop(string? value = null)
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

	public Video WithLang(string? value = null)
	{
		Lang = value;
		return this;
	}

	public string? Loop
	{
		set
		{
			writer.Write(" loop=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithLoop(string? value = null)
	{
		Loop = value;
		return this;
	}

	public string? Muted
	{
		set
		{
			writer.Write(" muted=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithMuted(string? value = null)
	{
		Muted = value;
		return this;
	}

	public string? Playsinline
	{
		set
		{
			writer.Write(" playsinline=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithPlaysinline(string? value = null)
	{
		Playsinline = value;
		return this;
	}

	public string? Poster
	{
		set
		{
			writer.Write(" poster=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithPoster(string? value = null)
	{
		Poster = value;
		return this;
	}

	public string? Preload
	{
		set
		{
			writer.Write(" preload=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithPreload(string? value = null)
	{
		Preload = value;
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

	public Video WithRole(string? value = null)
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

	public Video WithSlot(string? value = null)
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

	public Video WithSpellcheck(string? value = null)
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

	public Video WithSrc(string? value = null)
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

	public Video WithStyle(string? value = null)
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

	public Video WithTabindex(string? value = null)
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

	public Video WithTitle(string? value = null)
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

	public Video WithTranslate(string? value = null)
	{
		Translate = value;
		return this;
	}

	public string? Width
	{
		set
		{
			writer.Write(" width=\"");
			writer.Write(value);
			writer.Write('"');
		}
	}

	public Video WithWidth(string? value = null)
	{
		Width = value;
		return this;
	}

	public Video WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public Video WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
