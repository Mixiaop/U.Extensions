using System;

/// <summary>
/// �ж��ַ�����������������
/// </summary>
public static partial class Extensions
{
    public static bool NotIn(this String @this, params String[] values)
    {
        return Array.IndexOf(values, @this) == -1;
    }
}