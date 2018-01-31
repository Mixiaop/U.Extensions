using System;

public static partial class Extensions
{

    public static String Concat(this String str0, String str1)
    {
        return String.Concat(str0, str1);
    }


    public static String Concat(this String str0, String str1, String str2)
    {
        return String.Concat(str0, str1, str2);
    }

    /// <summary>
    /// 连接多个字符串实例
    /// </summary>
    /// <param name="str0"></param>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <param name="str3"></param>
    /// <returns></returns>
    public static String Concat(this String str0, String str1, String str2, String str3)
    {
        return String.Concat(str0, str1, str2, str3);
    }
}