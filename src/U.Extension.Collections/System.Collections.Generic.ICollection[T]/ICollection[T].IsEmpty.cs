using System.Collections.Generic;

public static partial class Extensions
{
    public static bool IsEmpty<T>(this ICollection<T> @this)
    {
        return @this.Count == 0;
    }
}