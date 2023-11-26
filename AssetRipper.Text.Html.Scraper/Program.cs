using AngleSharp;
using AngleSharp.Dom;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Text.Html.Scraper;

class Program
{
	private const string UrlElements = "https://developer.mozilla.org/en-US/docs/Web/HTML/Element";
	private const string UrlAttributes = "https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes";
	private const string GlobalAttribute = "Global attribute";

	static void Main()
	{
		Dictionary<string, List<string>> elements = Scrape();
		SaveAsJson(elements);
	}

	static Dictionary<string, List<string>> Scrape()
	{
		Dictionary<string, List<string>> htmlElements = new();
		ScrapeElements(htmlElements);
		ScrapeAttributes(htmlElements);
		return htmlElements;
	}

	static void ScrapeElements(Dictionary<string, List<string>> htmlElements)
	{
		IConfiguration config = Configuration.Default.WithDefaultLoader();
		IBrowsingContext context = BrowsingContext.New(config);
		IDocument document = context.OpenAsync(UrlElements).GetAwaiter().GetResult();

		foreach (IElement td in document.QuerySelectorAll("table td:first-child"))
		{
			foreach (string e in td.TextContent.Split(','))
			{
				if (TryTrim(e, out string? element))
				{
					htmlElements[element] = new();
				}
			}
		}
	}

	static void ScrapeAttributes(Dictionary<string, List<string>> htmlElements)
	{
		IConfiguration config = Configuration.Default.WithDefaultLoader();
		IBrowsingContext context = BrowsingContext.New(config);
		IDocument document = context.OpenAsync(UrlAttributes).GetAwaiter().GetResult();

		foreach (IElement tr in document.QuerySelectorAll("table tr"))
		{
			IElement? td1 = tr.QuerySelector("td:first-child code");
			IElement? td2 = tr.QuerySelector("td:nth-child(2)");

			if (td1 != null && td2 != null)
			{
				string attr = td1.TextContent;
				if (attr is "data-*")
				{
					//The asterisk is a wild card, so including this isn't very helpful.
					//The attribute is for custom data.
					//https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/data-*
					continue;
				}

				foreach (string e in td2.TextContent.Split(','))
				{
					if (TryTrim(e, out string? element))
					{
						if (element is GlobalAttribute)
						{
							foreach (List<string> value in htmlElements.Values)
							{
								value.Add(attr);
							}
						}
						else
						{
							htmlElements[element].Add(attr);
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

	static void SaveAsJson(Dictionary<string, List<string>> htmlElements)
	{
		using (StreamWriter sw = new StreamWriter("html-elements.json"))
		{
			IOrderedEnumerable<string> sortedElements = htmlElements.Keys.OrderBy(k => k);
			sw.Write(JsonConvert.SerializeObject(sortedElements, Formatting.Indented));
		}

		using (StreamWriter sw = new StreamWriter("html-elements-attributes.json"))
		{
			IOrderedEnumerable<KeyValuePair<string, List<string>>> sortedElements = htmlElements.OrderBy(e => e.Key);
			sw.Write(JsonConvert.SerializeObject(sortedElements, Formatting.Indented));
		}
	}
}