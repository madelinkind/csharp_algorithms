using System;
using System.Collections.Concurrent;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCsharpAlgorithms
{
    [TestClass]
    public class TestMaximumNumber
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "All numbers must be integers")]
        public void MaximumNumberFailsWithTextValue()
        {
            int result = Semana3.MaximumNumber("4", "5", "pepe");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "All numbers must be integers")]
        public void MaximumNumberFailsWithFloatValue()
        {
            int result = Semana3.MaximumNumber("1.5", "5", "9");
        }

        [TestMethod]
        public void MaximumNumberWorksWithNegativeNumbers()
        {
            int result = Semana3.MaximumNumber("-1", "-5", "-9");

            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void MaximumNumberWorksForPositiveNumbers()
        {
            int result = Semana3.MaximumNumber("1", "5", "9");

            Assert.AreEqual(result, 9);
        }
    }
}
