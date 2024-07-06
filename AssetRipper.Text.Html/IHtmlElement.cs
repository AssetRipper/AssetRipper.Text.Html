namespace AssetRipper.Text.Html;

public interface IHtmlElement<TSelf> where TSelf : IHtmlElement<TSelf>, allows ref struct
{
	static abstract ReadOnlySpan<string> SupportedAttributes { get; }
	static abstract string Name { get; }
	static abstract bool IsVoidElement { get; }
	static abstract TSelf Create(TextWriter writer); //Start?
	TextWriter Writer { get; }
	void Close();
	HtmlElementCloser End();
}
