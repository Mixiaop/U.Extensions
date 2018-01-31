using System;
using System.Text;

/// <summary>
/// 从字符串提取 Double 类型
/// </summary>
public static partial class Extensions
{
    public static double ExtractDouble(this string @this)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < @this.Length; i++)
        {
            if (Char.IsDigit(@this[i]) || @this[i] == '.')
            {
                if (sb.Length == 0 && i > 0 && @this[i - 1] == '-')
                {
                    sb.Append('-');
                }
                sb.Append(@this[i]);
            }
        }

        return Convert.ToDouble(sb.ToString());
    }
}