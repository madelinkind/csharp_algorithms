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
            long result = Semana4.FactorialNumber("-6");
        }

        [TestMethod]
        public void WorksForPositiveNumbers()
        {
            long result = Semana4.FactorialNumber("4");

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
            bool result = Semana4.PrimeNumber("pepe");
        }

        [TestMethod]
        public void WorksForPrimeNummber()
        {
            bool result = Semana4.PrimeNumber("5");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WorksForNotPrimeNummber()
        {
            bool result = Semana4.PrimeNumber("10");

            Assert.AreEqual(false, result);
        }
    }
}
