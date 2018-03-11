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
            execRomanToDecimalConverter("CCCLXV", 365);
        }
        [TestMethod]
        public void TestWithRomanNumberWithAnIncreasingValueSequenceAtEnd()
        {
            execRomanToDecimalConverter("CCLXXXIX", 289);
        }

        [TestMethod]
        public void TestWithRomanNumberWithAnIncreasingValueSequenceInMiddle()
        {
            execRomanToDecimalConverter("MDCIXLV", 1664);
        }

        [TestMethod]
        public void TestWithRomanNumberWithMultipleIncreasingValueSequence()
        {
            execRomanToDecimalConverter("MIVXLCD", 1444);
        }

        public void execRomanToDecimalConverter(String input, int expected)
        {
            RomanToDecimal rmn = new RomanToDecimal();
            int number = rmn.converter(input);
            Assert.AreEqual(expected, number);
        }
    }
}