namespace AssetRipper.Text.Html;

public readonly ref struct HtmlElementCloser
{
	private readonly TextWriter writer;
	private readonly string content;

	internal HtmlElementCloser(TextWriter writer, string content)
	{
		this.writer = writer;
		this.content = content;
	}

	public void Dispose()
	{
		writer.Write(content);
	}

	public static HtmlElementCloser operator +(HtmlElementCloser x, HtmlElementCloser y)
	{
		Validate(x, y);
		return new HtmlElementCloser(x.writer, y.content + x.content);

		static void Validate(HtmlElementCloser x, HtmlElementCloser y)
		{
			if (x.writer != y.writer)
			{
				throw new ArgumentException("Only closers with the same TextWriter can be merged.");
			}
		}
	}
}
