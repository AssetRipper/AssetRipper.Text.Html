using AngleSharp;
using AngleSharp.Dom;
using AssetRipper.Text.Html.Model;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Text.Html.Scraper;

static class Program
{
	private const string UrlElements = "https://developer.mozilla.org/en-US/docs/Web/HTML/Element";
	private const string UrlAttributes = "https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes";
	private const string GlobalAttribute = "Global attribute";

	static void Main()
	{
		HtmlJson elements = Scrape();
		string json = elements.ToJson();
		File.WriteAllText("html-elements-attributes.json", json);
	}

	static HtmlJson Scrape()
	{
		Dictionary<string, (List<string>, string)> htmlElements = new();
		List<string> globalAttributes = new();
		Dictionary<string, string> attributeDescriptions = new();
		ScrapeElements(htmlElements);
		ScrapeAttributes(htmlElements, globalAttributes, attributeDescriptions);
		globalAttributes.Sort();
		return new HtmlJson(
			htmlElements.OrderBy(p => p.Key).Select(p => new HtmlElementData(p.Key, p.Value.Item2, p.Value.Item1)).ToList(),
			globalAttributes,
			attributeDescriptions.OrderBy(p => p.Key).ToList());
	}

	static void ScrapeElements(Dictionary<string, (List<string>, string)> htmlElements)
	{
		IConfiguration config = Configuration.Default.WithDefaultLoader();
		IBrowsingContext context = BrowsingContext.New(config);
		IDocument document = context.OpenAsync(UrlElements).GetAwaiter().GetResult();
		
		foreach (IElement tr in document.QuerySelectorAll("table tr"))
		{
			IElement? td1 = tr.QuerySelector("td:first-child");
			IElement? td2 = tr.QuerySelector("td:nth-child(2)");

			if (td1 == null || td2 == null)
			{
				continue;
			}

			string description = td2.TextContent.RemoveExtraWhiteSpace();

			foreach (string e in td1.TextContent.Split(','))
			{
				if (TryTrim(e, out string? element))
				{
					htmlElements[element] = (new(), description);
				}
			}
		}
	}

	static void ScrapeAttributes(Dictionary<string, (List<string>, string)> htmlElements, List<string> globalAttributes, Dictionary<string, string> attributeDescriptions)
	{
		IConfiguration config = Configuration.Default.WithDefaultLoader();
		IBrowsingContext context = BrowsingContext.New(config);
		IDocument document = context.OpenAsync(UrlAttributes).GetAwaiter().GetResult();

		foreach (IElement tr in document.QuerySelectorAll("table tr"))
		{
			IElement? td1 = tr.QuerySelector("td:first-child code");
			IElement? td2 = tr.QuerySelector("td:nth-child(2)");
			IElement? td3 = tr.QuerySelector("td:nth-child(3)");

			if (td1 != null && td2 != null && td3 != null)
			{
				string attr = td1.TextContent;
				if (attr is "data-*")
				{
					//The asterisk is a wild card, so including this isn't very helpful.
					//The attribute is for custom data.
					//https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/data-*
					continue;
				}

				string description = td3.TextContent.RemoveExtraWhiteSpace();

				attributeDescriptions[attr] = description;

				foreach (string e in td2.TextContent.Split(','))
				{
					if (TryTrim(e, out string? element))
					{
						if (element is GlobalAttribute)
						{
							globalAttributes.Add(attr);
						}
						else
						{
							htmlElements[element].Item1.Add(attr);
						}
					}
				}
			}
		}
	}

	private static bool TryTrim(string value, [NotNullWhen(true)] out string? trimmed)
	{
		string local = value.Trim();
		if (local is GlobalAttribute)
		{
			trimmed = GlobalAttribute;
			return true;
		}
		else if (local.Length > 2 && local[0] is '<' && local[^1] is '>')
		{
			trimmed = local[1..^1];
			return true;
		}
		else
		{
			//contenteditable
			trimmed = null;
			return false;
		}
	}

	private static string RemoveExtraWhiteSpace(this string value)
	{
		return string.Join(' ', value.Split([' ', '\n', '\r', '\t'], StringSplitOptions.RemoveEmptyEntries));
	}
}
