using System;
using System.Diagnostics;
using ExtensionMethods;

namespace CsharpAlgorithms
{
    public enum TriangleType
    {
        NONE,
        TRIANGLE_INEQUALITY,
        SCALENE,
        ISOSCELES,
        EQUILATERAL,
    }

    public enum WriteSpeedType
    {
        FAST,
        REGULAR,
        SLOW,
    }

    public enum FastNameType
    {
        FIRST_NAME_FAST,
        SECOND_NAME_FAST,
        THIRD_NAME_FAST,
    }

    public static class Week3
    {

        /// <summary>
        /// Find the largest of three numbers using Math.Max
        /// </summary>
        public static int MaximumNumber(string value1, string value2, string value3)
        {
            bool jIsNumber = int.TryParse(value1, out int j);
            bool kIsNumber = int.TryParse(value2, out int k);
            bool mIsNumber = int.TryParse(value3, out int m);

            // check that all values are integer
            if (!jIsNumber || !kIsNumber || !mIsNumber)
                throw new ArgumentException("All numbers must be integers");

            return MaxAmongThreeNumbers(j, k, m);
        }

        private static int MaxAmongThreeNumbers(int a, int b, int c)
        {
            int bigger = Math.Max(Math.Max(a, b), c);
            return bigger;
        }

        /// <summary>
        /// Determines the writing speed
        /// </summary>
        public static WriteSpeedType WriteSpeed()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Type your name?");

            crono.Start();
            string name = Console.ReadLine();
            crono.Stop();

            int charactersCount = name.Length;
            double elapsedSeconds = crono.ElapsedMilliseconds / 1000.0;
            double charactersPerSecond = charactersCount / elapsedSeconds;

            if (charactersPerSecond > 2)
                return WriteSpeedType.FAST;
            else if (charactersPerSecond >= 1 && charactersPerSecond <= 2)
                return WriteSpeedType.REGULAR;
            else
                return WriteSpeedType.SLOW;
        }

        /// <summary>
        /// Determines which of the three names were written faster
        /// </summary>
        /// 
        public static (string, string, string, double, double, double) Values()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Type your name three times");

            crono.Start();
            string firstName = Console.ReadLine();
            crono.Stop();
            long firstTimeName = crono.ElapsedMilliseconds;
            crono.Restart();

            crono.Start();
            string secondName = Console.ReadLine();
            crono.Stop();
            long secondTimeName = crono.ElapsedMilliseconds;
            crono.Restart();

            crono.Start();
            string thirdName = Console.ReadLine();
            crono.Stop();
            long thirdTimeName = crono.ElapsedMilliseconds;
            crono.Restart();

            return (firstName, secondName, thirdName, firstTimeName, secondTimeName, thirdTimeName);
        }

        public static FastNameType FastName()
        {
            (string firstName, string secondName, string thirdName, double firstTimeName, double secondTimeName, double thirdTimeName) = Values();

            bool isNumber = firstName.IsAllLetters();
            bool isNumber1 = secondName.IsAllLetters();
            bool isNumber2 = thirdName.IsAllLetters();

            if (!isNumber || !isNumber1 || !isNumber2)
                throw new ArgumentException("Error, you must enter letters");

            if (firstName != secondName || secondName != thirdName)
                throw new ArgumentException("Error, you have typed some of the names wrong. Run the program again");

            if (firstTimeName <= secondTimeName && firstTimeName <= thirdTimeName)
                return FastNameType.FIRST_NAME_FAST;
            else if (secondTimeName <= thirdTimeName)
                return FastNameType.SECOND_NAME_FAST;
            else
                return FastNameType.THIRD_NAME_FAST;
        }

        /// <summary>
        /// Determines the type of triangle
        /// </summary>
        public static TriangleType TypeTriangle(string value1, string value2, string value3)
        {

            bool isNumberA = float.TryParse(value1, out float a);
            bool isNumberB = float.TryParse(value2, out float b);
            bool isNumberC = float.TryParse(value3, out float c);

            if (!isNumberA || !isNumberB || !isNumberC)
                throw new ArgumentException("Triangle sides should be numbers");

            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.NONE;

            if (a + b <= c || b + c <= a || c + a <= b)
                return TriangleType.TRIANGLE_INEQUALITY;

            if (a == b && a == c)
                return TriangleType.EQUILATERAL;
            else if (a != b && b != c && a != c)
                return TriangleType.SCALENE;
            else
                return TriangleType.ISOSCELES;
        }

        /// <summary>
        /// Orders from least to greatest and determines the average between the 3 numbers
        /// </summary>
        public static (int, int, int, double) OrderAvrg(string number1, string number2, string number3)
        {
            bool isNumber1 = int.TryParse(number1, out int value1);
            bool isNumber2 = int.TryParse(number2, out int value2);
            bool isNumber3 = int.TryParse(number3, out int value3);

            if (!isNumber1 || !isNumber2 || !isNumber3)
                throw new ArgumentException("All numbers must be integers");

            double average = ((double)value1 + (double)value2 + (double)value3) / 3;

            if (value1 <= value2 && value1 <= value3)
            {
                if (value2 <= value3)
                    return (value1, value2, value3, average);
                else
                    return (value1, value3, value2, average);
            }
            else if (value2 <= value1 && value2 <= value3)
            {
                if (value1 <= value3)
                    return (value2, value1, value3, average);
                else
                    return (value2, value3, value1, average);
            }
            else
            {
                if (value1 <= value2)
                    return (value3, value1, value2, average);
                else
                    return (value3, value2, value1, average);
            }
        }

        /// <summary>
        /// Orders with Sort() from least to greatest and determines the average between the 3 numbers
        /// </summary>
        public static (int, int, int, double) OrderAvrgSort(string number1, string number2, string number3)
        {
            bool isNumber1 = int.TryParse(number1, out int value1);
            bool isNumber2 = int.TryParse(number2, out int value2);
            bool isNumber3 = int.TryParse(number3, out int value3);

            if (!isNumber1 || !isNumber2 || !isNumber3)
                throw new ArgumentException("All numbers must be integers");

            int[] order = new int[3] { value1, value2, value3 };

            Array.Sort(order);

            double average = ((double)value1 + (double)value2 + (double)value3) / 3;

            var list = (order[0], order[1], order[2], average);

            return list;
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        public static bool PrimeNumber(string number)
        {
            bool isNumber = int.TryParse(number, out int value);

            if (!isNumber)
                throw new ArgumentException("Error, you must enter whole numbers");

            if (value < 1 || value > 100)
                throw new ArgumentException("Error, entered a number outside the indicated range");

            int i = 1;
            int cont = 0;

            while (i <= value && cont != 3)
            {
                if (value % i == 0)
                    cont++;
                i++;
            }
            if (cont != 2)
                return false;

            else
                return true;
        }

        /// <summary>
        /// Determines the day following the given date
        /// </summary>
        public static (int, int, int) NextDay(string value1, string value2, string value3)
        {
            int month_next = 0;
            int day_next = 0;
            int year_next = 0;

            bool isNumber1 = int.TryParse(value1, out int day);
            bool isNumber2 = int.TryParse(value2, out int month);
            bool isNumber3 = int.TryParse(value3, out int year);

            if (!isNumber1 || !isNumber2 || !isNumber3 || year < 4 || month > 12 || month < 1 || day > 31 || day < 1)
            {
                throw new ArgumentException("Error, incorrect date");
            }
            if ((day > 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day > 29 && month == 2) || (day > 28 && month == 2 && year % 4 != 0) || (day == 29 && month == 2 && ((year % 4 != 0 || year % 100 == 0) && (year % 400 != 0))))
            {
                throw new ArgumentException("Error, incorrect date");
            }
            if ((day == 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day == 29 && month == 2) || (day == 28 && month == 2 && (year % 4 != 0 || (year % 100 == 0) && (year % 400 != 0)) || day == 31))
            {
                month_next = month + 1;
                day_next = 1;
            }
            else
            {
                day_next = day + 1;
                month_next = month;
            }
            if (day_next == 1 && month_next == 13)
            {
                month_next = 1;
                year_next = year + 1;
            }
            else
                year_next = year;
            return (day_next, month_next, year_next);
        }
    }

}

