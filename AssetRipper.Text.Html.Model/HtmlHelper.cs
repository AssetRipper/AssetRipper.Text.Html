using System.Text;

namespace AssetRipper.Text.Html.Model;

internal static class HtmlHelper
{
	//https://developer.mozilla.org/en-US/docs/Glossary/Void_element
	private static readonly HashSet<string> VoidElements = [
		"area",
		"base",
		"br",
		"col",
		"embed",
		"hr",
		"img",
		"input",
		"link",
		"meta",
		"param",
		"source",
		"track",
		"wbr"
	];

	public static bool IsVoidElement(string name) => VoidElements.Contains(name);

	public static string ConvertKebabToPascal(string kebabCase)
	{
		StringBuilder pascalCaseBuilder = new(kebabCase.Length);

		bool capitalizeNext = true;

		foreach (char c in kebabCase)
		{
			if (c == '-')
			{
				capitalizeNext = true;
			}
			else
			{
				pascalCaseBuilder.Append(capitalizeNext ? char.ToUpperInvariant(c) : c);
				capitalizeNext = false;
			}
		}

		return pascalCaseBuilder.ToString();
	}

	public static string MaybeAppendUnderscore(string value, string invalidString)
	{
		return value == invalidString ? value + '_' : value;
	}
}
