using System.Net;

namespace AssetRipper.Text.Html;

public static class TextWriterExtensions
{
	public static void WriteHtml(this TextWriter writer, string? text)
	{
		WebUtility.HtmlEncode(text, writer);
	}

	public static void WriteHtml(this TextWriter writer, char c)
	{
		if (NeedsEncoded(c))
		{
			writer.WriteHtml(new string(new ReadOnlySpan<char>(in c)));
		}
		else
		{
			writer.Write(c);
		}
	}

	private static bool NeedsEncoded(char c)
	{
		//See WebUtility.IndexOfHtmlEncodingChars
		return (c is '<' or '>' or '"' or '\'' or '&') || (c is >= (char)160 and < (char)256) || char.IsSurrogate(c);
	}
}
