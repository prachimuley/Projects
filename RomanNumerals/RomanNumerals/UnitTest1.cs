using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToDecimalNameSpace;
namespace RomanNumerals
{
    [TestClass]
    public class UnitTest1
    {
        // ToDo: Using Nunit this can actually be achieved in a single test method with multiple input attributes
        [TestMethod]
        public void TestWithRomanNumberWithAllDecreasingValueSequence()
        {
            execRomanToDecimalConverter("CCCLXV");
        }
        [TestMethod]
        public void TestWithRomanNumberWithAnIncreasingValueSequence()
        {
            execRomanToDecimalConverter("CCLXXXIX");
        }

    public void execRomanToDecimalConverter(String input)
        {
            RomanToDecimal rmn = new RomanToDecimal();
            int number = rmn.converter(input);
            Assert.AreEqual(365, number);
        }
    }
}