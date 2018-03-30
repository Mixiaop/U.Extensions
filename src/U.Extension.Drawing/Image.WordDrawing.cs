using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public static partial class Extensions
{
    public const string DefaultFontFamily = "Microsoft YaHei";
    public static void WordDrawing(this Image img, string text, Point point, string saveFilePath, Brush brush = null, Font font = null)
    {
        if (saveFilePath.IsNullOrEmpty()) {
            throw new Exception("Please enter saveFilePath");
        }

        if (brush == null)
            brush = new SolidBrush(Color.Black);


        if (font == null)
            font = new Font(DefaultFontFamily, 20);

        using (Graphics g = Graphics.FromImage(img)) {
            g.DrawString(text, font, brush, point);
        }

        img.Save(saveFilePath, ImageFormat.Gif);
        img.Dispose();
    }

    public static void WordDrawing(this Image img, string text, Point point, string saveFilePath, int fontSize, bool isFontBold = false) {
        var font = new Font(DefaultFontFamily, fontSize, (isFontBold ? FontStyle.Bold : FontStyle.Regular));
        
        img.WordDrawing(text, point, saveFilePath, null, font);
    }
}