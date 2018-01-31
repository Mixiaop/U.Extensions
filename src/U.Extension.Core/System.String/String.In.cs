using System;

public static partial class Extensions
{
    /// <summary>
    /// 判断字符串是否存在指定的数组中
    /// </summary>
    /// <param name="this"></param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static bool In(this String @this, params String[] values)
    {
        return Array.IndexOf(values, @this) != -1;
    }
}