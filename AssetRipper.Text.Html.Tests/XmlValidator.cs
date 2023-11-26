using System.Xml;

namespace AssetRipper.Text.Html.Tests;

internal static class XmlValidator
{
	public static void AssertValid(Action<TextWriter> action)
	{
		StringWriter writer = new();
		action(writer);
		AssertValid(writer.ToString());
	}

	public static void AssertValid(string xml)
	{
		Assert.DoesNotThrow(() => ValidateXml(xml));
	}

	public static void AssertInvalid(string xml)
	{
		Assert.Throws<XmlException>(() => ValidateXml(xml));
	}

	private static void ValidateXml(string xml)
	{
		using XmlReader reader = XmlReader.Create(new StringReader(xml));
		while (reader.Read())
		{
		}
	}
}
