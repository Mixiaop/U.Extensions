using System;

public static partial class Extensions
{
    public static String Format(this String format, Object arg0)
    {
        return String.Format(format, arg0);
    }

    public static String Format(this String format, Object arg0, Object arg1)
    {
        return String.Format(format, arg0, arg1);
    }

    public static String Format(this String format, Object arg0, Object arg1, Object arg2)
    {
        return String.Format(format, arg0, arg1, arg2);
    }

    public static String Format(this String format, Object[] args)
    {
        return String.Format(format, args);
    }
}