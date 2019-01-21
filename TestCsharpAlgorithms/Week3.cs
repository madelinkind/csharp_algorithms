using System;
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

    [TestClass]
    public class TestClassifyTriangle
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Triangle sides should be numbers")]
        public void FailsWithTextValue()
        {
            TriangleType result = Semana3.TypeTriangle("4", "5", "tito");
        }

        [TestMethod]
        public void WorksForInvalidTriangle()
        {
            TriangleType t = Semana3.TypeTriangle("0", "4", "9");

            Assert.AreEqual(t, TriangleType.NONE);
        }

        [TestMethod]
        public void WorksForScaleneTriangle()
        {
            TriangleType t = Semana3.TypeTriangle("5,9", "3", "7");

            Assert.AreEqual(t, TriangleType.SCALENE);
        }

        [TestMethod]
        public void WorksForIsoscelesTriangle()
        {
            TriangleType t = Semana3.TypeTriangle("4", "4", "6");

            Assert.AreEqual(t, TriangleType.ISOSCELES);
        }

        [TestMethod]
        public void WorksForEquilateralTriangle()
        {
            TriangleType t = Semana3.TypeTriangle("4", "4", "4");

            Assert.AreEqual(t, TriangleType.EQUILATERAL);
        }

        [TestMethod]
        public void WorksForTriangleInequality()
        {
            TriangleType t = Semana3.TypeTriangle("7", "3", "3");

            Assert.AreEqual(t, TriangleType.TRIANGLE_INEQUALITY);
        }
    }

    [TestClass]
    public class TestNumberPrime
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter whole numbers")]
        public void FailsWithTextValue()
        {
            bool result = Semana3.PrimeNumber("pepe");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, entered a number outside the indicated range")]
        public void FailsOutOfRage1To100()
        {
            bool result = Semana3.PrimeNumber("101");
        }

        [TestMethod]
        public void WorksForPrimeNumber()
        {
            bool result = Semana3.PrimeNumber("5");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WorksForNotPrimeNumber()
        {
            bool result = Semana3.PrimeNumber("10");

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class TestOrderAvrgSort
        {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter whole numbers")]
        public void FailsWithTextValue()
        {
            var result = Semana3.OrderAvrgSort("5","4.52","lol");
        }

        [TestMethod]
        public void WorksForIntegerNumber()
        {
            var result = Semana3.OrderAvrgSort("5", "25", "10");

            Assert.AreEqual((5, 10, 25, 13.333333333333334), result);
        }
    }

    [TestClass]
    public class TestNextDay
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithIncorrectDateValues()
        {
            var result = Semana3.NextDay("28", "13", "2018");
        }

        [TestMethod]
        public void WorksForCorrectDate()
        {
            var result = Semana3.NextDay("5", "4", "2018");

            Assert.AreEqual((6, 4, 2018), result);
        }

        [TestMethod]
        public void WorksForIncorrectDate()
        {
            var result = Semana3.NextDay("25", "3", "2018");

            Assert.AreNotEqual((27, 3, 2018), result);
        }
    }
}
