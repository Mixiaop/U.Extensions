using System;

public static partial class Extensions
{
    /// <summary>
    /// �ж��ַ����Ƿ����ָ����������
    /// </summary>
    /// <param name="this"></param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static bool In(this String @this, params String[] values)
    {
        return Array.IndexOf(values, @this) != -1;
    }
}