using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// ÅÐ¶Ï¼¯ºÏÊÇ·ñ¿Õ or null
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="this"></param>
    /// <returns></returns>
    public static bool IsNotNullOrEmpty<T>(this ICollection<T> @this)
    {
        return @this != null && @this.Count != 0;
    }
}