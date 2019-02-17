using System;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
        [ExpectedException(typeof(ArgumentException), "Error, you must enter a number greater than zero")]
        public void FailsWhithTextValue()
        {
            long result = Week4.FactorialNumber("pepe");
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
            List<string> list_number = new List<string> { "made", "rosario", "carmenates123", "pipo", "" };
            var result = Week4.LongerLength(list_number);

            Assert.AreEqual((1, "carmenates123"), result);
        }

        [TestMethod]
        public void WorkForLongerRepeatedStrings()
        {
            List<string> list_number = new List<string> { "made", "rosario", "rosario", "pipo", "" };
            var result = Week4.LongerLength(list_number);

            Assert.AreEqual((2, "rosario"), result);
        }

        [TestMethod]
        public void WorkForDifferentStringSameLengthLonger()
        {
            List<string> list_number = new List<string> { "made", "mariantonieta132*", "rosario", "rosario", "pipo", "mariantonieta132*", "fidelia", "mariantoniete132/", "mariantonieta132*", "" };
            var result = Week4.LongerLength(list_number);

            Assert.AreEqual((4, "mariantonieta132*"), result);
        }
    }

    [TestClass]
    public class TestCountPositiveNegativeNumbers
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected int value")]
        public void FailWhithTextValue()
        {
            NumberSign result = Week4.CountPositiveNegativeNumbers("nombre");
        }

        [TestMethod]
        public void WorkForPositiveNumber()
        {
            NumberSign result = Week4.CountPositiveNegativeNumbers("20");

            Assert.AreEqual(result, NumberSign.POSITIVE);
        }

        [TestMethod]
        public void WorkForNegativeNumber()
        {
            NumberSign result = Week4.CountPositiveNegativeNumbers("-9");

            Assert.AreEqual(result, NumberSign.NEGATIVE);
        }

        [TestMethod]
        public void WorkForZeroNumber()
        {
            NumberSign result = Week4.CountPositiveNegativeNumbers("0");

            Assert.AreEqual(result, NumberSign.ZERO);
        }

        [TestMethod]
        public void WorkForBlankSpace()
        {
            NumberSign result = Week4.CountPositiveNegativeNumbers("");

            Assert.AreEqual(result, NumberSign.BLANK_SPACE);
        }
    }

    [TestClass]
    public class TestIsPrimeNumber
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected int value")]
        public void FailWithNumberTextValue()
        {
            IsPrime result = Week4.IsPrimeNumber("pepe");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected int value")]
        public void FailWithNumberLessThanZero()
        {
            IsPrime result = Week4.IsPrimeNumber("-1");
        }

        [TestMethod]
        public void WorkForBlankSpace()
        {
            IsPrime result = Week4.IsPrimeNumber("");

            Assert.AreEqual(result, IsPrime.BLANK_SPACE);
        }

        [TestMethod]
        public void WorkForNonPrimeNumbers()
        {
            IsPrime result = Week4.IsPrimeNumber("10");

            Assert.AreEqual(result, IsPrime.NO_PRIME);
        }

        [TestMethod]
        public void WorkForPrimeNumbers()
        {
            IsPrime result = Week4.IsPrimeNumber("2");

            Assert.AreEqual(result, IsPrime.Prime);
        }
    }

    [TestClass]
    public class TestAveragePositive
    {
        [ExpectedException(typeof(ArgumentException), "Expected int value")]
        [TestMethod]
        public void FailTextValue()
        {
        List<string> list_number = new List<string> { "pepe", "4", "-2", "4", "4" };
            double result = Week4.AveragePositive(list_number);
        }

        [TestMethod]
        public void WorkForPositiveNumber()
        {
            List<string> list_number = new List<string> { "4", "4", "4", "4" };
            double result = Week4.AveragePositive(list_number);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void WorkForZeroNumber()
        {
            List<string> list_number = new List<string> { "0", "4", "4", "4" };
            double result = Week4.AveragePositive(list_number);

            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void WorkForIntermediateZeroNumber()
        {
            List<string> list_number = new List<string> { "4", "4", "0", "4" };
            double result = Week4.AveragePositive(list_number);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void WorkForNegativeNumber()
        {
            List<string> list_number = new List<string> { "-5", "-9", "-2", "-1" };
            double result = Week4.AveragePositive(list_number);

            Assert.AreEqual(double.NaN, result);
        }
    }

    [TestClass]
    public class TestIsCorrectDate
    {
        [TestMethod]
        public void WorkForCorrectDate()
        {
            bool result = Week4.IsCorrectDate("1", "2", "2018");

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WorkForIncorrectDate()
        {
            bool result = Week4.IsCorrectDate("31", "2", "2018");

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void WorkForIncorrectDateTextValue()
        {
            bool result = Week4.IsCorrectDate("pp", "2", "2018");

            Assert.AreEqual(result, false);
        }
    }

    [TestClass]
    public class TestFollowingDate
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, invalid date")]
        public void FailsWithTextValues()
        {
            var result = Week4.FollowingDate("pepe", "12", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithInvalidDate()
        {
            var result = Week4.FollowingDate("32", "12", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithInvalidDayAccordinMonth()
        {
            var result = Week4.FollowingDate("31", "2", "2018");
        }

        [TestMethod]
        public void WorksForTheLastDayMonthExceptDecember()
        {
            var result = Week4.FollowingDate("28", "2", "2018");

            Assert.AreEqual((1, 3, 2018), result);
        }

        [TestMethod]
        public void WorksForLastDayMonthDecember()
        {
            var result = Week4.FollowingDate("31", "12", "2018");

            Assert.AreEqual((1, 1, 2019), result);
        }

        [TestMethod]
        public void WorksForTheDayMonthExceptLast()
        {
            var result = Week4.FollowingDate("13", "2", "2018");

            Assert.AreEqual((14, 2, 2018), result);
        }
    }
    [TestClass]
    public class TestPreviousDate
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, invalid date")]
        public void FailsWithTextValues()
        {
            var result = Week4.PreviousDate("pepe", "12", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithInvalidDate()
        {
            var result = Week4.PreviousDate("32", "12", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithInvalidDayAccordinMonth()
        {
            var result = Week4.PreviousDate("31", "2", "2018");
        }

        [TestMethod]
        public void WorksForFirstDayMonthJanuary()
        {
            var result = Week4.PreviousDate("1", "1", "2018");

            Assert.AreEqual((31, 12, 2017), result);
        }

        [TestMethod]
        public void WorksForTheFirstDayMonthWithQuantityDaysDifferent31()
        {
            var result = Week4.PreviousDate("1", "2", "2018");

            Assert.AreEqual((31, 1, 2018), result);
        }


        [TestMethod]
        public void WorksForTheFirstDayMonthMarchYearNoBear()
        {
            var result = Week4.PreviousDate("1", "3", "2018");

            Assert.AreEqual((28, 2, 2018), result);
        }

        [TestMethod]
        public void WorksForTheFirstDayMonthMarchYearBear()
        {
            var result = Week4.PreviousDate("1", "3", "2016");

            Assert.AreEqual((29, 2, 2016), result);
        }

        [TestMethod]
        public void WorksForTheFirstDayMonthWithQuantityDaysDifferent30ExceptDecemberMarch()
        {
            var result = Week4.PreviousDate("1", "5", "2018");

            Assert.AreEqual((30, 4, 2018), result);
        }

        [TestMethod]
        public void WorksForDayMonthExceptFirstday()
        {
            var result = Week4.PreviousDate("5", "5", "2018");

            Assert.AreEqual((4, 5, 2018), result);
        }
    }

    [TestClass]
    public class TestIncreaseDate
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, invalid date")]
        public void FailsWithTextValues()
        {
            var result = Week4.IncreaseDate("pepe", "12", "2018", "2");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithIncorrectNumberOfDaysAdd()
        {
            var result = Week4.IncreaseDate("32", "12", "2018", "pp");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithInvalidDayAccordinMonth()
        {
            var result = Week4.IncreaseDate("31", "2", "2018", "2");
        }

        [TestMethod]
        public void WorksWhenIncreaseDaysMonth()
        {
            var result = Week4.IncreaseDate("2", "2", "2018", "5");

            Assert.AreEqual((7, 2, 2018), result);
        }

        [TestMethod]
        public void WorksWhenIncreasesOneYear()
        {
            var result = Week4.IncreaseDate("1", "1", "2018", "365");

            Assert.AreEqual((1, 1, 2019), result);
        }

        [TestMethod]
        public void WorksWhenIncreasesOneMonth()
        {
            var result = Week4.IncreaseDate("1", "3", "2018", "31");

            Assert.AreEqual((1, 4, 2018), result);
        }
    }

    [TestClass]
    public class TestDifferentTwoDay
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, invalid date")]
        public void FailsWithTextValuesFirstDay()
        {
            int result = Week4.DifferentTwoDates("pepe", "12", "2018", "5", "4", "2015");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, invalid date")]
        public void FailsWithTextValuesSecondDay()
        {
            int result = Week4.DifferentTwoDates("1", "12", "2018", "pp", "4", "2015");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithMonthFirstDateGreaterThanMonthSecondDate()
        {
            int result = Week4.DifferentTwoDates("31", "12", "2018", "25", "4", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithDayFirstDateGreaterThanDaySecondDateEqualsMonthYear()
        {
            int result = Week4.DifferentTwoDates("31", "4", "2018", "25", "4", "2018");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Error, incorrect date")]
        public void FailsWithYearFirstDateGreaterThanYearSecondDateEquals()
        {
            int result = Week4.DifferentTwoDates("31", "4", "2019", "25", "4", "2018");
        }

        [TestMethod]
        public void WorksForMonthYearEquals()
        {
            int result = Week4.DifferentTwoDates("23", "12", "2018", "25", "12", "2018");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void WorksDifferenceOneYear()
        {
            int result = Week4.DifferentTwoDates("31", "12", "2018", "31", "12", "2019");

            Assert.AreEqual((365), result);
        }

        [TestMethod]
        public void WorksDifferenceTwoYear()
        {
            int result = Week4.DifferentTwoDates("31", "12", "2018", "31", "12", "2020");

            Assert.AreEqual((730), result);
        }
    }

    [TestClass]
    public class TestBiggerNumber
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected int value")]
        public void FailWithTextValue()
        {
            List<string> line = new List<string> {"pp", "3", "2"};
            int result = Week4.BiggerNumber(line);
        }

        [TestMethod]
        public void WorksForIntegerNumber()
        {
            List<string> line = new List<string> { "5", "3", "2" };
            int result = Week4.BiggerNumber(line);

            Assert.AreEqual(5, result);
        }
    }
}
