using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace U.Extension.Tests.Core
{
    [TestClass]
    public class CoreObject
    {
        [TestMethod]
        public void Join()
        {
            var joinChar = ",";
            string[] joinList = { "1", "2", "3" };

            var result = joinChar.Join(joinList);
            Console.Write(result);
        }
    }
}
