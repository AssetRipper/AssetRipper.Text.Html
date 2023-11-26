namespace AssetRipper.Text.Html.Tests;

public partial class A_Tests
{
	[Test]
	public void SelfClosingIsValidXml() => XmlValidator.AssertValid(static (writer) => new A(writer).Close());

	[Test]
	public void PairClosingIsValidXml() => XmlValidator.AssertValid(static (writer) =>
	{
		using (new A(writer).End())
		{
		}
	});
}
