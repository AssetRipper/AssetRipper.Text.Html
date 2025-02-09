namespace AssetRipper.Text.Html;

/// <summary>
/// A class for custom HTML elements.
/// </summary>
public readonly ref struct CustomHtmlElement : IHtmlElement<CustomHtmlElement>
{
	private readonly TextWriter writer;
	private readonly string name;

	internal CustomHtmlElement(TextWriter writer, string name)
	{
		this.writer = writer;
		this.name = name;
	}

	public void Close() => writer.Write("/>");

	public HtmlElementCloser End()
	{
		writer.Write('>');
		return new HtmlElementCloser(writer, $"</{name}>");
	}

	static ReadOnlySpan<string> IHtmlElement<CustomHtmlElement>.SupportedAttributes => [];

	static string IHtmlElement<CustomHtmlElement>.Name => throw new NotSupportedException();

	static bool IHtmlElement<CustomHtmlElement>.IsVoidElement => false;

	TextWriter IHtmlElement<CustomHtmlElement>.Writer => writer;

	static CustomHtmlElement IHtmlElement<CustomHtmlElement>.Create(TextWriter writer)
	{
		throw new NotSupportedException();
	}
}
