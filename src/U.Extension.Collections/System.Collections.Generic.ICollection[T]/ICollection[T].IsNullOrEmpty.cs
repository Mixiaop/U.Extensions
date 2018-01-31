using System.Collections.Generic;

public static partial class Extensions
{
    public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
    {
        return @this == null || @this.Count == 0;
    }

}