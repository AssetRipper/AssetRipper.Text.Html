using AngleSharp;
using AngleSharp.Dom;
using AssetRipper.Text.Html.Model;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Text.Html.Scraper;

class Program
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
		Dictionary<string, List<string>> htmlElements = new();
		List<string> globalAttributes = new();
		ScrapeElements(htmlElements);
		ScrapeAttributes(htmlElements, globalAttributes);
		globalAttributes.Sort();
		return new HtmlJson(htmlElements.OrderBy(p => p.Key).ToList(), globalAttributes);
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

	static void ScrapeAttributes(Dictionary<string, List<string>> htmlElements, List<string> globalAttributes)
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
							globalAttributes.Add(attr);
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
}
