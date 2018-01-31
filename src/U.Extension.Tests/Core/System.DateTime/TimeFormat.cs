using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace U.Extension.Tests.Core
{
    [TestClass]
    public class TimeFormat
    {

        [TestMethod]
        public void ToRelativeTime()
        {
            var date = DateTime.Now;

            Console.WriteLine(date.ToRelativeTime(true, true));
            Console.WriteLine(date.ToRelativeTime(true, false));

            var date2 = new DateTime(2018, 1, 1, 12, 12, 59);
            Console.WriteLine(date2.ToRelativeTime(true, true));
            Console.WriteLine(date2.ToRelativeTime(true, false));


            var date3 = new DateTime(2018, 12, 1, 12, 12, 59);
            Console.WriteLine(date3.ToRelativeTime(true, true));
            Console.WriteLine(date3.ToRelativeTime(true, false));
        }
    }
}
