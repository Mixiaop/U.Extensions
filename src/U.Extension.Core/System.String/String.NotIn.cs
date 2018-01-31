using System;

/// <summary>
/// 判断字符串不存在于数组中
/// </summary>
public static partial class Extensions
{
    public static bool NotIn(this String @this, params String[] values)
    {
        return Array.IndexOf(values, @this) == -1;
    }
}