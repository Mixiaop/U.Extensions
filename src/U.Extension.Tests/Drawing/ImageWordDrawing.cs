using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace U.Extension.Tests.Drawing
{
    [TestClass]
    public class ImageWordDrawing
    {

        [TestMethod]
        public void DrawingTests()
        {
            var path = @"D:\!Github\U.Extensions\src\U.Extension.Tests\Drawing\test.jpg";
            var path2 = @"D:\!Github\U.Extensions\src\U.Extension.Tests\Drawing\test2.jpg";
            Image img = Image.FromFile(path);
            img.WordDrawing("你好", new Point(100, 150), path2, 30, true);
        }
    }
}
