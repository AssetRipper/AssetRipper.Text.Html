using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetRipper.Text.Html;

public interface IHtmlElement<TSelf> where TSelf : IHtmlElement<TSelf>, allows ref struct
{
	static abstract TSelf Create(TextWriter writer);
}
