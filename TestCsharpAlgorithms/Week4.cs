using System;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCsharpAlgorithms
{
    [TestClass]
    public class TestFactorialNumber
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter a number greater than zero")]
        public void FailsWhithTextValueOrValueLessOrEqualsZero()
        {
            long result = Week4.FactorialNumber("-6");
        }

        [TestMethod]
        public void WorksForPositiveNumbers()
        {
            long result = Week4.FactorialNumber("4");

            Assert.AreEqual(24, result);
        }
    }

    [TestClass]
    public class TestNumberPrime1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter whole numbers")]
        public void FailsWithTextValue()
        {
            bool result = Week4.PrimeNumber("pepe");
        }

        [TestMethod]
        public void WorksForPrimeNummber()
        {
            bool result = Week4.PrimeNumber("5");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WorksForNotPrimeNummber()
        {
            bool result = Week4.PrimeNumber("10");

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class TestStringLongerLength
    {

        [TestMethod]
        public void WorkForLongerString()
        {
            string[] list_number = { "made", "rosario", "carmenates123", "pipo", "" };
            var result = Week4.LongerLength(list_number);

            Assert.AreEqual((1, "carmenates123"), result);
        }

        [TestMethod]
        public void WorkForLongerRepeatedStrings()
        {
            string[] list_number = { "made", "rosario", "rosario", "pipo", "" };
            var result = Week4.LongerLength(list_number);

            Assert.AreEqual((2, "rosario"), result);
        }

        [TestMethod]
        public void WorkForDifferentStringSameLengthLonger()
        {
            string[] list_number = { "made", "mariantonieta132*", "rosario", "rosario", "pipo", "mariantonieta132*", "fidelia", "mariantoniete132/", "mariantonieta132*", "" };
            var result = Week4.LongerLength(list_number);

            Assert.AreEqual((4, "mariantonieta132*"), result);
        }
    }
}
