using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// È¥³ýHTML
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    public static string StripHtml(this string @this)
    {
        var path = new StringBuilder(@this);
        var sb = new StringBuilder();

        int pos = 0;

        while (pos < path.Length)
        {
            char ch = path[pos];
            pos++;

            if (ch == '<')
            {
                // LOOP until we close the html tag
                while (pos < path.Length)
                {
                    ch = path[pos];
                    pos++;

                    if (ch == '>')
                    {
                        break;
                    }

                    if (ch == '\'')
                    {
                        // SKIP attribute starting with single quote
                        pos = GetIndexAfterNextSingleQuote(path, pos, true);
                    }
                    else if (ch == '"')
                    {
                        // SKIP attribute starting with double quote
                        pos = GetIndexAfterNextDoubleQuote(path, pos, true);
                    }
                }
            }
            else
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}