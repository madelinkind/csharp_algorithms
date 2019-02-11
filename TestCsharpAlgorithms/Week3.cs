using System;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCsharpAlgorithms
{
    [TestClass]
    public class TestWriteSpeed
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter letters")]
        public void FailsWithIncorrectValues()
        {
            var result = Week3.WriteSpeed("1", 4);
        }

        [TestMethod]
        public void WorksForFastName()
        {
            WriteSpeedType fastSpeed = Week3.WriteSpeed("pepe", 1);

            Assert.AreEqual(WriteSpeedType.FAST, fastSpeed);
        }

        [TestMethod]
        public void WorksForRegularName()
        {
            WriteSpeedType regularSpeed = Week3.WriteSpeed("made", 2);

            Assert.AreEqual(regularSpeed, WriteSpeedType.REGULAR);
        }

        [TestMethod]
        public void WorksForLowName()
        {
            WriteSpeedType lowSpeed = Week3.WriteSpeed("tuti", 10);

            Assert.AreEqual(lowSpeed, WriteSpeedType.SLOW);
        }
    }

    [TestClass]
    public class TestWriteFastName
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter letters")]
        public void FailsWithIncorrectValues()
        {
            var result = Week3.FastName("1", "pedro", "pedro", 4, 3, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you have typed some of the names wrong")]
        public void FailsWithDifferentsName()
        {
            var result = Week3.FastName("marta", "pepo", "pepo", 3, 4, 1);
        }

        [TestMethod]
        public void WorksForFastFirstName()
        {
            FastNameType firstName = Week3.FastName("pepe", "pepe", "pepe", 1, 2, 2);

            Assert.AreEqual(firstName, FastNameType.FIRST_NAME_FAST);
        }

        [TestMethod]
        public void WorksForFastSecondName()
        {
            FastNameType secondName = Week3.FastName("made", "made", "made", 7, 4, 8);

            Assert.AreEqual(secondName, FastNameType.SECOND_NAME_FAST);
        }

        [TestMethod]
        public void WorksForFastThirdName()
        {
            FastNameType thirdName = Week3.FastName("tuti", "tuti", "tuti", 8, 9, 3);

            Assert.AreEqual(thirdName, FastNameType.THIRD_NAME_FAST);
        }

        [TestMethod]
        public void WorksForFastFirstSecondNameEqual()
        {
            FastNameType thirdName = Week3.FastName("tuti", "tuti", "tuti", 3, 3, 9);

            Assert.AreEqual(thirdName, FastNameType.FIRST_NAME_FAST);
        }

        [TestMethod]
        public void WorksForFastFirstThirdNameEqual()
        {
            FastNameType firstThirdName = Week3.FastName("tuti", "tuti", "tuti", 1, 9, 1);

            Assert.AreEqual(firstThirdName, FastNameType.FIRST_NAME_FAST);
        }

        [TestMethod]
        public void WorksForFastFirstSecondThirdNameEqual()
        {
            FastNameType firstThirdName = Week3.FastName("tuti", "tuti", "tuti", 1, 1, 1);

            Assert.AreEqual(firstThirdName, FastNameType.FIRST_NAME_FAST);
        }

        [TestMethod]
        public void WorksForFastSecondThirdNameEqual()
        {
            FastNameType thirdName = Week3.FastName("tuti", "tuti", "tuti", 8, 3, 3);

            Assert.AreEqual(thirdName, FastNameType.SECOND_NAME_FAST);
        }
    }

    [TestClass]
    public class TestClassifyTriangle
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Triangle sides should be numbers")]
        public void FailsWithTextValue()
        {
            TriangleType result = Week3.TypeTriangle("4", "5", "tito");
        }

        [TestMethod]
        public void WorksForInvalidTriangle()
        {
            TriangleType t = Week3.TypeTriangle("0", "4", "9");

            Assert.AreEqual(t, TriangleType.NONE);
        }

        [TestMethod]
        public void WorksForScaleneTriangle()
        {
            TriangleType t = Week3.TypeTriangle("5.9", "3", "7");

            Assert.AreEqual(t, TriangleType.SCALENE);
        }

        [TestMethod]
        public void WorksForIsoscelesTriangle()
        {
            TriangleType t = Week3.TypeTriangle("4", "4", "6");

            Assert.AreEqual(t, TriangleType.ISOSCELES);
        }

        [TestMethod]
        public void WorksForEquilateralTriangle()
        {
            TriangleType t = Week3.TypeTriangle("4", "4", "4");

            Assert.AreEqual(t, TriangleType.EQUILATERAL);
        }

        [TestMethod]
        public void WorksForTriangleInequality()
        {
            TriangleType t = Week3.TypeTriangle("7", "3", "3");

            Assert.AreEqual(t, TriangleType.TRIANGLE_INEQUALITY);
        }
    }

        [TestClass]
    public class TestOrderAvrg
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter whole numbers")]
        public void FailsWithTextValue()
        {
            var result = Week3.OrderAvrg("5", "4", "pepe");
        }

        [TestMethod]
        public void WorksForOrder123()
        {
            var result = Week3.OrderAvrg("2", "4", "8");

            Assert.AreEqual((2, 4, 8, 4.6666666666666666666666666666667), result);
        }

        [TestMethod]
        public void WorksFor132()
        {
            var result = Week3.OrderAvrg("5", "8", "7");

            Assert.AreEqual((5, 7, 8, 6.6666666666666666666666666666667), result);
        }

        [TestMethod]
        public void WorksFor213()
        {
            var result = Week3.OrderAvrg("7", "3", "8");

            Assert.AreEqual((3, 7, 8, 6), result);
        }

        [TestMethod]
        public void WorksFor312()
        {
            var result = Week3.OrderAvrg("7","3","4");

            Assert.AreEqual((3, 4, 7, 4.6666666666666666666666666666667), result);
        }

        [TestMethod]
        public void WorksFor231()
        {
            var result = Week3.OrderAvrg("4", "7", "3");

            Assert.AreEqual((3, 4, 7, 4.6666666666666666666666666666667), result);
        }

        [TestMethod]
        public void WorksFor321()
        {
            var result = Week3.OrderAvrg("7", "4", "3");

            Assert.AreEqual((3, 4, 7, 4.6666666666666666666666666666667), result);
        }
    }

    [TestClass]
    public class TestOrderAvrgSort
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter whole numbers")]
        public void FailsWithTextValue()
        {
            var result = Week3.OrderAvrgSort("5", "4", "pepe");
        }

        [TestMethod]
        public void WorksForIntegerNumber()
        {
            var result = Week3.OrderAvrgSort("2", "4", "8");

            Assert.AreEqual((2, 4, 8, 4.6666666666666666666666666666667), result);
        }
    }

    [TestClass]
    public class TestNumberPrime
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, you must enter whole numbers")]
        public void FailsWithTextValue()
        {
            bool result = Week3.PrimeNumber("pepe");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, entered a number outside the indicated range")]
        public void FailsOutOfRage1To100()
        {
            bool result = Week3.PrimeNumber("101");
        }

        [TestMethod]
        public void WorksForPrimeNumber()
        {
            bool result = Week3.PrimeNumber("5");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WorksForNotPrimeNumber()
        {
            bool result = Week3.PrimeNumber("10");

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class TestNextDay
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, invalid date")]
        public void FailsWithTextValues()
        {
            var result = Week3.NextDay("pepe", "12", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithInvalidDate()
        {
            var result = Week3.NextDay("32", "12", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithInvalidDayAccordinMonth()
        {
            var result = Week3.NextDay("31", "2", "2018");
        }

        [TestMethod]
        public void WorksForTheLastDayMonthExceptDecember()
        {
            var result = Week3.NextDay("28", "2", "2018");

            Assert.AreEqual((1, 3, 2018), result);
        }

        [TestMethod]
        public void WorksForLastDayMonthDecember()
        {
            var result = Week3.NextDay("31", "12", "2018");

            Assert.AreEqual((1, 1, 2019), result);
        }

        [TestMethod]
        public void WorksForTheDayMonthExceptLast()
        {
            var result = Week3.NextDay("13", "2", "2018");

            Assert.AreEqual((14, 2, 2018), result);
        }
    }
}


