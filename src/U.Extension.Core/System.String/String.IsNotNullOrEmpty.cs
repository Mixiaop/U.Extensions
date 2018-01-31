public static partial class Extensions
{
    public static bool IsNotNullOrEmpty(this string @this)
    {
        return !string.IsNullOrEmpty(@this);
    }
}