namespace AssetRipper.Text.Html;

public static class CustomAttributes
{
	public static TSelf WithCustomAttribute<TSelf>(this TSelf element, string key, string? value = null)
		where TSelf : IHtmlElement<TSelf>, allows ref struct
	{
		WriteKey(element.Writer, key);
		WriteValue(element.Writer, value);
		return element;
	}

	public static TSelf WithCustomAttributes<TSelf>(this TSelf element, scoped ReadOnlySpan<(string, string?)> attributes)
		where TSelf : IHtmlElement<TSelf>, allows ref struct
	{
		foreach ((string key, string? value) in attributes)
		{
			WriteKey(element.Writer, key);
			WriteValue(element.Writer, value);
		}
		return element;
	}

	private static void WriteKey(TextWriter writer, string key)
	{
		writer.Write(' ');
		writer.Write(key);
	}

	private static void WriteValue(TextWriter writer, string? value)
	{
		writer.Write("=\"");
		writer.Write(value);
		writer.Write('"');
	}
}
