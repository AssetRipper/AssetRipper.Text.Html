# AssetRipper.Text.Html

A fast, NativeAOT-compatible library for writing minified HTML with C#. Although the output is not forever guaranteed to be valid XHTML, it currently is.

## Justification

[ASP.NET does not currently support native compilation for Razor Pages.](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/native-aot?view=aspnetcore-8.0)

## API Styles

We offer two styles of using the library:

```cs
//Fluent API
new Img(writer).WithSrc("www.example.com").Close();
using (new A(writer).WithClass("btn").End())
{
	//Inner content
}

//Initialization API
new Img(writer) { Src = "www.example.com" }.Close();
using (new A(writer) { Class = "btn" }.End())
{
	//Inner content
}
```

## End and Close

These two methods are required to conclude an html element constructor call. `End` is for normal elements, and `Close` is for self-closed elements.

## References

* https://developer.mozilla.org/en-US/docs/Web/HTML/Element
* https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes
* https://developer.mozilla.org/en-US/docs/Glossary/Void_element