namespace AssetRipper.Text.Html.Model;

public sealed class HtmlJsonLoader
{
	private const string NamespacePrefix = "AssetRipper.Text.Html.Model.";

	public static void Load(out List<HtmlAttribute> globalAttributes, out List<HtmlAttribute> localAttributes, out List<HtmlElement> elements)
	{
		using Stream stream = typeof(HtmlJsonLoader).Assembly.GetManifestResourceStream(NamespacePrefix + "html-elements-attributes.json")
			?? throw new NullReferenceException("Could not load resource stream.");

		string json = new StreamReader(stream).ReadToEnd();

		HtmlJson data = HtmlJson.FromJson(json);

		Dictionary<string, HtmlAttribute> attributeDictionary = new();

		globalAttributes = new();
		foreach (string name in data.GlobalAttributes)
		{
			HtmlAttribute attribute = new HtmlAttribute(name, true);
			attributeDictionary.Add(name, attribute);
			globalAttributes.Add(attribute);
		}

		localAttributes = new();
		foreach ((_, List<string> attributeList) in data.Elements)
		{
			foreach (string name in attributeList)
			{
				if (attributeDictionary.ContainsKey(name))
				{
					continue;
				}

				HtmlAttribute attribute = new HtmlAttribute(name, false);
				attributeDictionary.Add(name, attribute);
				localAttributes.Add(attribute);
			}
		}

		elements = new();
		foreach ((string elementName, List<string> attributeArray) in data.Elements)
		{
			elements.Add(new HtmlElement(elementName, attributeArray.Union(data.GlobalAttributes).Order(), attributeDictionary));
		}
	}
}
