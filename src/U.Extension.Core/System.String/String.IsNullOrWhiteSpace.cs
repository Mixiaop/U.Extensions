using System;

public static partial class Extensions
{
    public static Boolean IsNullOrWhiteSpace(this String value)
    {
        return String.IsNullOrWhiteSpace(value);
    }
}