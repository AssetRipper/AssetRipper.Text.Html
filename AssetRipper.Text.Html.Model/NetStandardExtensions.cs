namespace AssetRipper.Text.Html.Model;
#if NETSTANDARD
internal static class NetStandardExtensions
{
	public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> pair, out TKey key, out TValue value)
	{
		key = pair.Key;
		value = pair.Value;
	}

	public static IEnumerable<T> Order<T>(this IEnumerable<T> enumerable)
	{
		return enumerable.OrderBy(t => t);
	}
}
#endif
