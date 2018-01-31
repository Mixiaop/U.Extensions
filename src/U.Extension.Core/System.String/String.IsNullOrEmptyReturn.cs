public static partial class Extensions
{
    /// <summary>
    /// 如果为null或空则返回默认值
    /// </summary>
    /// <param name="s"></param>
    /// <param name="toReturn"></param>
    /// <returns></returns>
    public static string IsNullOrEmptyReturn(this string s, string toReturn = "") => s.IsNotNullOrEmpty() ? s : toReturn;
}
