using System.Globalization;
using System.Text.RegularExpressions;

public static partial class Extensions
{
    public static string RemoveHtml(this string str)
    {
        if (!string.IsNullOrEmpty(str))
        {
            string pattern = "<.*?>";
            str = new Regex(pattern).Replace(str, "");
            str = str.Replace("&nbsp;", " ");
        }
        return str;
    }

    public static string RemoveMoreSpace(this string content)
    {
        if (string.IsNullOrEmpty(content))
        {
            return "";
        }
        Regex regex = new Regex(@"\s{2,}", RegexOptions.Multiline);
        return regex.Replace(content, " ");
    }

    public static string RemoveStart(this string s, int len)
    {
        if ((s == null) || (s.Length == 0))
        {
            return s;
        }
        return s.Remove(0, len);
    }

    public static bool StartWithIgnoreCase(this string s, string begin)
    {
        if ((s == null) || (s.Length == 0))
        {
            return false;
        }
        return s.StartsWith(begin, true, CultureInfo.CurrentCulture);
    }

    public static string SubString2(this string str, int maxlen)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        if (str.Length <= maxlen)
        {
            return str;
        }
        return str.Substring(0, maxlen);
    }

    public static string SubString3(this string str, int maxlen)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        if (str.Length <= maxlen)
        {
            return str;
        }
        return (str.Substring(0, maxlen) + "...");
    }
}
