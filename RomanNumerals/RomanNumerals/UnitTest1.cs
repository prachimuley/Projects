using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToDecimalNameSpace;
namespace RomanNumerals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RomanToDecimal rmn = new RomanToDecimal();
            int number = rmn.converter("MMXVI");
            Assert.AreEqual(2016,number);
        }
    }
}
