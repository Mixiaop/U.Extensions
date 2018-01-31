using System;

public static partial class Extensions
{
    public static Boolean IsNotNullOrWhiteSpace(this string value)
    {
        return !String.IsNullOrWhiteSpace(value);
    }
}