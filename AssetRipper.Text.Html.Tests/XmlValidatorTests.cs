namespace AssetRipper.Text.Html.Tests;

public class XmlValidatorTests
{
	[TestCase("<img/>")]
	[TestCase("<img />")]
	[TestCase("<a></a>")]
	[TestCase("<p><a></a></p>")]
	[TestCase("""<div disabled=""></div>""")]
	public void ValidCases(string xml)
	{
		XmlValidator.AssertValid(xml);
	}

	[TestCase("<img>")]
	[TestCase("<a><a>")]
	[TestCase("<p><a></p></a>")]
	[TestCase("<div disabled></div>")]
	public void InvalidCases(string xml)
	{
		XmlValidator.AssertInvalid(xml);
	}
}
