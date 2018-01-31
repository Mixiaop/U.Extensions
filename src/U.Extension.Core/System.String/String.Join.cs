using System;
using System.Collections.Generic;

/// <summary>
///  为指定数组添加分割符 {"1","2","3"} = "1,2,3" 
/// </summary>
public static partial class Extensions
{
    public static String Join(this String separator, String[] value)
    {
        return String.Join(separator, value);
    }

    public static String Join(this String separator, Object[] values)
    {
        return String.Join(separator, values);
    }

    public static String Join<T>(this String separator, IEnumerable<T> values)
    {
        return String.Join(separator, values);
    }

    public static String Join(this String separator, IEnumerable<String> values)
    {
        return String.Join(separator, values);
    }

    public static String Join(this String separator, String[] value, Int32 startIndex, Int32 count)
    {
        return String.Join(separator, value, startIndex, count);
    }
}