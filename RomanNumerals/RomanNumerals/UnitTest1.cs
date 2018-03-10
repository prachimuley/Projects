using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RomanNumerals rmn = new RomanNumerals();
            int number = rmn.romanToDecimal("MMXVI");
            Assert.AreEqual(2016,number);
        }
    }
}
