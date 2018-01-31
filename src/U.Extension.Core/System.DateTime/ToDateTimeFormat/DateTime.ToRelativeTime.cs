using System;

/// <summary>
/// Datetime 转相对时间
/// 如：刚刚、几分钟前
/// </summary>
public static partial class Extensions
{
    /// <summary>
    /// Datetime 转相对时间
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="includeTime">是否包含时间</param>
    /// <param name="asPlusMinus">是否显示多少分钟</param>
    /// <param name="compareTo">相比对的时间</param>
    /// <param name="includeSign">是否包含时间符号</param>
    /// <returns></returns>
    public static string ToRelativeTime(this DateTime dt, bool includeTime = true, bool asPlusMinus = false, DateTime? compareTo = null, bool includeSign = true)
    {
        var comp = compareTo ?? DateTime.Now;
        if (asPlusMinus)
        {
            return dt <= comp
                ? ToRelativeTimeSimple(comp - dt, includeSign ? "-" : "")
                : ToRelativeTimeSimple(dt - comp, includeSign ? "+" : "");
        }
        return dt <= comp
            ? ToRelativeTimePast(dt, comp, includeTime)
            : ToRelativeTimeFuture(dt, comp, includeTime);
    }

    #region Private Methods
    private static string ToRelativeTimePast(DateTime dt, DateTime utcNow, bool includeTime = true)
    {
        var ts = utcNow - dt;
        var delta = ts.TotalSeconds;

        if (delta < 1) return "刚刚";
        if (delta < 60) return ts.Seconds == 1 ? "1秒前" : ts.Seconds.ToString() + " 几秒前";
        if (delta < 3600 /*60 mins * 60 sec*/) return ts.Minutes == 1 ? "1分钟前" : ts.Minutes.ToString() + "分钟前";
        if (delta < 86400 /*24 hrs * 60 mins * 60 sec*/) return ts.Hours == 1 ? "1小时前" : ts.Hours.ToString() + "小时前";

        var days = ts.Days;
        if (days == 1) return "昨天";
        if (days <= 2) return days.ToString() + "天前";
        if (utcNow.Year == dt.Year) return dt.ToString(includeTime ? "MM-dd HH:mm" : "MM-dd");
        return dt.ToString(includeTime ? @"yyyy-MM-dd HH:mm" : @"yyyy-MM-dd");
    }

    private static string ToRelativeTimeFuture(DateTime dt, DateTime utcNow, bool includeTime = true)
    {
        TimeSpan ts = dt - utcNow;
        double delta = ts.TotalSeconds;

        if (delta < 1) return "刚刚";
        if (delta < 60) return ts.Seconds == 1 ? "1秒后" : ts.Seconds.ToString() + "秒后";
        if (delta < 3600 /*60 mins * 60 sec*/) return ts.Minutes == 1 ? "1分钟后" : ts.Minutes.ToString() + "分钟后";
        if (delta < 86400 /*24 hrs * 60 mins * 60 sec*/) return ts.Hours == 1 ? "1小时后" : ts.Hours.ToString() + "小时后";

        var days = (int)Math.Round(ts.TotalDays, 0);
        if (days == 1) return "明天";
        if (days <= 10) return days.ToString() + "天后" + (days > 1 ? "s" : "");

        if (utcNow.Year == dt.Year) return dt.ToString(includeTime ? "MM-dd HH:mm" : "MM-dd");
        return dt.ToString(includeTime ? @"yyyy-MM-dd HH:mm" : @"yyyy-MM-dd");
    }

    private static string ToRelativeTimeSimple(TimeSpan ts, string sign)
    {
        var delta = ts.TotalSeconds;
        if (delta < 1) return "1秒前";
        if (delta < 60) return sign + ts.Seconds.ToString() + "秒";
        if (delta < 3600 /*60 mins * 60 sec*/) return sign + ts.Minutes.ToString() + "分钟";
        if (delta < 86400 /*24 hrs * 60 mins * 60 sec*/) return sign + ts.Hours.ToString() + "小时";
        return ts.Days.ToString() + "天" + (sign == "-" ? "前" : "后");
    }
    #endregion
}
