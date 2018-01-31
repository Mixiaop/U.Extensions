using System;

public static partial class Extensions
{
    public static bool IsNull(this String @this)
    {
        return @this == null;
    }
}