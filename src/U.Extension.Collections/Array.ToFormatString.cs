using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// 格式化数组
    /// [1,2,3] = "1,2,3"
    /// [1,2,3] = "[1]-[2]-[3]"
    /// [1,2,3] = "123"
    /// </summary>
    /// <param name="this"></param>
    /// <param name="packageStr">自定义项</param>
    /// <param name="segmentStr"></param>
    /// <returns></returns>
    public static string ToFormatString(this string[] @this, string packageStr = "", string segmentStr = ",")
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < @this.Length; i++)
        {
            sb.Append(packageStr + @this[i] + packageStr);
            if (i < (@this.Length - 1))
                sb.Append(segmentStr);

        }
        return sb.ToString();
    }

    /// <summary>
    /// 格式化数组
    /// [1,2,3] = "1,2,3"
    /// [1,2,3] = "123"
    /// </summary>
    /// <param name="this"></param>
    /// <param name="segmentStr"></param>
    /// <returns></returns>
    public static string ToFormatString(this int[] @this, string segmentStr = ",")
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < @this.Length; i++)
        {
            sb.Append(@this[i].ToString());
            if (i < (@this.Length - 1))
                sb.Append(segmentStr);

        }
        return sb.ToString();
    }
}
