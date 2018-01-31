using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace U.Extension.Tests.Core
{
    /// <summary>
    /// ExtractValueType 的摘要说明
    /// </summary>
    [TestClass]
    public class ExtractValueType
    {
        [TestMethod]
        public void ExtractDecimal()
        {
            var str = "hello 123 world4.00";
            Console.Write(str.ExtractDecimal());
        }


        [TestMethod]
        public void ExtractInt32()
        {
            var str = "hello 123 world4";
            Console.Write(str.ExtractInt32());
        }
    }
}
