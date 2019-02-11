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
        /// Determines the writing speed
        /// </summary>
        public static void WriteSpeedName()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Type your name?");

            crono.Start();
            string name = Console.ReadLine();
            crono.Stop();
            double time = crono.ElapsedMilliseconds / 1000.0;

            // define actual write speed
            WriteSpeedType writeSpeed = WriteSpeed(name, time);

            if (writeSpeed == WriteSpeedType.SLOW)
                Console.WriteLine("You are slow");
            else if (writeSpeed == WriteSpeedType.REGULAR)
                Console.WriteLine("You are regular");
            else if (writeSpeed == WriteSpeedType.FAST)
                Console.WriteLine("You are fast");
            else
                throw new ArgumentException("Unknown writing speed");
        }

        public static WriteSpeedType WriteSpeed(string name, double time)
        {
            if (!name.IsAllLetters())
                throw new ArgumentException("Error, you must enter letters");

            int charactersCount = name.Length;
            double charactersPerSecond = charactersCount / time;

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
        public static void FastestOfThreeName()
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

            FastNameType fastestName = FastName(firstName, secondName, thirdName, firstTimeName, secondTimeName, thirdTimeName);

            if (fastestName == FastNameType.FIRST_NAME_FAST)
                Console.WriteLine("You wrote the first name fastest");
            else if (fastestName == FastNameType.SECOND_NAME_FAST)
                Console.WriteLine("You wrote the second name fastest");
            else if (fastestName == FastNameType.THIRD_NAME_FAST)
                Console.WriteLine("You wrote the third name fastest");
            else
                throw new ArgumentException("Unknown name order");
        }

        public static FastNameType FastName(string firstName, string secondName, string thirdName, long firstTimeName, long secondTimeName, long thirdTimeName)
        {
            // validate all are letters only
            if (!firstName.IsAllLetters() || !secondName.IsAllLetters() || !thirdName.IsAllLetters())
                throw new ArgumentException("Error, you must enter letters");

            // validate that all names are equal
            if (firstName != secondName || secondName != thirdName)
                throw new ArgumentException("Error, you have typed some of the names wrong");

            if (firstTimeName <= secondTimeName && firstTimeName <= thirdTimeName)
                return FastNameType.FIRST_NAME_FAST;
            else if (secondTimeName <= thirdTimeName)
                return FastNameType.SECOND_NAME_FAST;
            else
                return FastNameType.THIRD_NAME_FAST;
        }

        public static void TriangleClassifier()
        {
            // read triangles sides
            string side1 = Console.ReadLine();
            string side2 = Console.ReadLine();
            string side3 = Console.ReadLine();

            // classify triangle
            TriangleType type = TypeTriangle(side1, side2, side3);

            if (type == TriangleType.EQUILATERAL)
                Console.WriteLine("Triangle is equilateral");
            else if (type == TriangleType.ISOSCELES)
                Console.WriteLine("Triangle is isosceles");
            else if (type == TriangleType.SCALENE)
                Console.WriteLine("Triangle is scalene");
            else if (type == TriangleType.TRIANGLE_INEQUALITY)
                Console.WriteLine("Triangle inequality did not hold");
            else if (type == TriangleType.NONE)
                Console.WriteLine("Triangle sides were not valid");
            else
                throw new ArgumentException("Unknown triangle type");
        }

        /// <summary>
        /// Determines the type of triangle
        /// </summary>
        public static TriangleType TypeTriangle(string side1, string side2, string side3)
        {
            // try to parse triangle sides
            bool side1Number = float.TryParse(side1, out float a);
            bool side2Number = float.TryParse(side2, out float b);
            bool side3Number = float.TryParse(side3, out float c);

            // all triangle sides are numbers
            if (!side1Number || !side2Number || !side3Number)
                throw new ArgumentException("Triangle sides should be numbers");

            // all triangle sizes must be positive
            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.NONE;

            // verify triangle inequality
            if (a + b <= c || b + c <= a || c + a <= b)
                return TriangleType.TRIANGLE_INEQUALITY;

            if (a == b && a == c)
                return TriangleType.EQUILATERAL;
            else if (a != b && b != c && a != c)
                return TriangleType.SCALENE;
            else
                return TriangleType.ISOSCELES;
        }

        public static void ThreeNumbersStats()
        {
            // read numbers from console
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            string number3 = Console.ReadLine();

            var result = OrderAvrg(number1, number2, number3);

            // output useful info
            Console.WriteLine("The smallest number is {0}", result.first);
            Console.WriteLine("The medium number is {0}", result.second);
            Console.WriteLine("The largest number is {0}", result.third);
            Console.WriteLine("The average is {0}", result.avg);
        }

        /// <summary>
        /// Orders from least to greatest and determines the average between the 3 numbers
        /// </summary>
        public static (int first, int second, int third, double avg) OrderAvrg(string number1, string number2, string number3)
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
        public static (int first, int second, int third, double avg) OrderAvrgSort(string number1, string number2, string number3)
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

        public static void PrimeNumber()
        {
            // read number from console
            string number = Console.ReadLine();

            // check if number is prime
            bool isPrime = IsPrimeNumber(number);

            if (isPrime)
                Console.WriteLine("Number {0} is prime", number);
            else
                Console.WriteLine("Number {0} is not prime", number);
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        public static bool IsPrimeNumber(string number)
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

        public static void GetNextDay()
        {
            Console.WriteLine("Write day:");
            string day = Console.ReadLine();

            Console.WriteLine("Write month:");
            string month = Console.ReadLine();

            Console.WriteLine("Write year:");
            string year = Console.ReadLine();

            // determine next day
            var result = NextDay(day, month, year);

            // output relevant information
            Console.WriteLine("Next day date is: {0}/{1}/{2}", result.day, result.month, result.year);
        }

        /// <summary>
        /// Determines the day following the given date
        /// </summary>
        public static (int day, int month, int year) NextDay(string value1, string value2, string value3)
        {
            int month_next = 0;
            int day_next = 0;
            int year_next = 0;

            bool isNumber1 = int.TryParse(value1, out int day);
            bool isNumber2 = int.TryParse(value2, out int month);
            bool isNumber3 = int.TryParse(value3, out int year);

            if (!isNumber1 || !isNumber2 || !isNumber3 || year < 4 || month > 12 || month < 1 || day > 31 || day < 1)
                throw new ArgumentException("Error, invalid date");

            if ((day > 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day > 29 && month == 2) || (day > 28 && month == 2 && year % 4 != 0) || (day == 29 && month == 2 && ((year % 4 != 0 || year % 100 == 0) && (year % 400 != 0))))
                throw new ArgumentException("Error, incorrect date");

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

