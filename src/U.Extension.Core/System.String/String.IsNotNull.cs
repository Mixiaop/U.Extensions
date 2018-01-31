using System;

public static partial class Extensions
{
    public static bool IsNotNull(this String @this)
    {
        return @this != null;
    }
}