# AssetRipper.Text.Html.Converter

This WIP tool converts existing HTML code to the C# syntax using the Fluent API.

## Whitespace Removal

It is not trivial to identify significant whitespace in HTML text.
My implementation tries to stay on the safe side because extra whitespace is easier to identify than missing whitespace.

A lot of superfluous calls are generated in areas where the whitespace has not been identified as insignificant.
They can be removed with this regex:

```regex
\n\s*writer\.Write\(' '\);
```