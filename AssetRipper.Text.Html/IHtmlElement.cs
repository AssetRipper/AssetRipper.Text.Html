namespace AssetRipper.Text.Html;

public interface IHtmlElement<TSelf> where TSelf : IHtmlElement<TSelf>, allows ref struct
{
	/// <summary>
	/// The supported attributes for the element.
	/// </summary>
	static abstract ReadOnlySpan<string> SupportedAttributes { get; }
	/// <summary>
	/// The name of the element.
	/// </summary>
	static abstract string Name { get; }
	/// <summary>
	/// Indicates whether the element is a void element.
	/// </summary>
	static abstract bool IsVoidElement { get; }
	/// <summary>
	/// Creates a new element.
	/// </summary>
	/// <param name="writer">The writer for the element.</param>
	/// <returns>A new element.</returns>
	static abstract TSelf Create(TextWriter writer);
	/// <summary>
	/// The writer for the element.
	/// </summary>
	TextWriter Writer { get; }
	/// <summary>
	/// Closes the element.
	/// </summary>
	void Close();
	/// <summary>
	/// Ends the element.
	/// </summary>
	/// <returns>
	/// The closer for the element.
	/// </returns>
	HtmlElementCloser End();
}
