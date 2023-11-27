namespace AssetRipper.Text.Html;

/// <summary>
/// A class for custom HTML elements.
/// </summary>
public readonly ref struct HtmlElement
{
	private readonly TextWriter writer;
	private readonly string name;

	internal HtmlElement(TextWriter writer, string name)
	{
		this.writer = writer;
		this.name = name;

	}

	public HtmlElement WithCustomAttribute(string key, string? value = null)
	{
		WriteKey(key);
		WriteValue(value);
		return this;
	}

	public HtmlElement WithCustomAttributes(scoped ReadOnlySpan<(string, string?)> attributes)
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
		return new HtmlElementCloser(writer, $"</{name}>");
	}
}
