using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    /// 确保字符串末尾是指定的字符，如果不是则添加
    /// </summary>
    /// <param name="str"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static string EnsureEndsWith(this string str, char c)
    {
        return EnsureEndsWith(str, c, StringComparison.InvariantCulture);
    }

    /// <summary>
    /// 确保字符串末尾是指定的字符，如果不是则添加
    /// </summary>
    /// <param name="str"></param>
    /// <param name="c"></param>
    /// <param name="comparisonType"></param>
    /// <returns></returns>
    public static string EnsureEndsWith(this string str, char c, StringComparison comparisonType)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }

        if (str.EndsWith(c.ToString(CultureInfo.InvariantCulture), comparisonType))
        {
            return str;
        }

        return str + c;
    }

    /// <summary>
    /// 确保字符串末尾是指定的字符，如果不是则添加
    /// </summary>
    /// <param name="str"></param>
    /// <param name="c"></param>
    /// <param name="ignoreCase"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public static string EnsureEndsWith(this string str, char c, bool ignoreCase, CultureInfo culture)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }

        if (str.EndsWith(c.ToString(culture), ignoreCase, culture))
        {
            return str;
        }

        return str + c;
    }
}
