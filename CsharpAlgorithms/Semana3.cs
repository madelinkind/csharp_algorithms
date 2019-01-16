using System;
using System.Diagnostics;
using ExtensionMethods;

namespace CsharpAlgorithms
{
    public static class Semana3
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
            //if (!jIsNumber || !kIsNumber || !mIsNumber)
            //{
            //    Console.WriteLine("You must type valid integer numbers");
            //    return;
            //}
                // get maximum of the three numbers
                int bigger = Math.Max(Math.Max(j, k), m);
                return bigger;
        }

        /// <summary>
        /// Determines the writing speed
        /// </summary>
        public static void Speed()
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
                Console.WriteLine("You are fast");
            else if (charactersPerSecond >= 1 && charactersPerSecond <= 2)
                Console.WriteLine("You are regular");
            else
                Console.WriteLine("You are slow");
        }

        /// <summary>
        /// Determines which of the three names were written faster
        /// </summary>
        public static void FastName()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Type your name three times");

            crono.Start();
            string firstName = Console.ReadLine();
            bool isNumber = firstName.IsAllLetters();
            crono.Stop();
            long firstTimeName = crono.ElapsedMilliseconds;
            crono.Restart();

            crono.Start();
            string secondName = Console.ReadLine();
            bool isNumber1 = secondName.IsAllLetters();
            crono.Stop();
            long secondTimeName = crono.ElapsedMilliseconds;
            crono.Restart();

            crono.Start();
            string thirdName = Console.ReadLine();
            bool isNumber2 = thirdName.IsAllLetters();
            crono.Stop();
            long thirdTimeName = crono.ElapsedMilliseconds;
            crono.Restart();

            if (!isNumber || !isNumber1 || !isNumber2)
            {
                Console.WriteLine("Error, you must enter letters");
                return;
            }
            if (firstName != secondName || secondName != thirdName)
            {
                Console.WriteLine("Error, you have typed some of the names wrong. Run the program again");
                return;
            }
            if (firstTimeName <= secondTimeName && firstTimeName <= thirdTimeName)
                Console.WriteLine("You exscribed the first name faster");
            else if (secondTimeName <= thirdTimeName)
                Console.WriteLine("You exscribed the second name faster");
            else
                Console.WriteLine("You exscribed the third name faster");
        }
              
        /// <summary>
        /// Determines the type of triangle
        /// </summary>
        public static void TypeTriangle()
        {
            Console.WriteLine("Entry three integer values");

            bool isNumberA = int.TryParse(Console.ReadLine(), out int a);
            bool isNumberB = int.TryParse(Console.ReadLine(), out int b);
            bool isNumberC = int.TryParse(Console.ReadLine(), out int c);

            if (!isNumberA || !isNumberB || !isNumberC)
            {
                Console.WriteLine("Triangle sides should be numbers");
                return;
            }

            if (a <= 0 && b <= 0 && c <= 0)
            {
                Console.WriteLine("Can't form a triangle");
                return;
            }

            if (a == b && a == c)
                Console.WriteLine("The triangle is equilateral");
            else if (a != b && b != c && a != c)
                Console.WriteLine("The triangle is scalene");
            else
                Console.WriteLine("The triangle is isosceles");
        }

        /// <summary>
        /// Orders from least to greatest and determines the average between the 3 numbers
        /// </summary>
        public static void OrderAvrg()
        {
            Console.WriteLine("Enter three integer values to sort");

            bool isNumber1 = int.TryParse(Console.ReadLine(), out int value1);
            bool isNumber2 = int.TryParse(Console.ReadLine(), out int value2);
            bool isNumber3 = int.TryParse(Console.ReadLine(), out int value3);

            if(!isNumber1 || !isNumber2 || !isNumber3)
            {
                Console.WriteLine("Error, you must enter whole numbers. Run the program again");
                return;
            }
            if (value1 <= value2 && value1 <= value3)
            {
                if (value2 <= value3)
                    Console.WriteLine("{0},{1},{2}", value1, value2, value3);
                else
                    Console.WriteLine("{0},{1},{2}", value1, value3, value2);
            }
            else if (value2 <= value1 && value2 <= value3)
            {
                if (value1 <= value3)
                    Console.WriteLine("{0},{1},{2}", value2, value1, value3);
                else
                    Console.WriteLine("{0},{1},{2}", value2, value3, value1);
            }
            else if (value3 <= value1 && value3 <= value2)
            {
                if (value1 <= value2)
                    Console.WriteLine("{0},{1},{2}", value3, value1, value2);
                else
                    Console.WriteLine("{0},{1},{2}", value3, value2, value1);
            }
            double average = ((double) value1 + (double) value2 + (double) value3) / 3;
            Console.WriteLine("El promedio es {0}", average);
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a number that is in the range of 1 to 100");
            bool isNumber = int.TryParse(Console.ReadLine(), out int value);
            int i = 1;
            int cont = 0;

            if (!isNumber)
            {
                Console.WriteLine("Error, you must enter whole numbers. Run the program again");
                return;
            }
            if (value < 1 || value > 100)
            {
                Console.WriteLine("Error, entered a number outside the indicated range. Run the program again.");
                return;
            }
            while (i <= value && cont != 3)
            {
                if (value % i == 0)
                    cont++;
                i++;
            }
            if (cont != 2)
                Console.WriteLine("The number is not prime");
            else
                Console.WriteLine("The number is prime");
        }

        /// <summary>
        /// Determines the day following the given date
        /// </summary>
        public static void NextDay()
        {
            int month_next = 0;
            int day_next = 0;
            int year_next = 0;

            Console.WriteLine("Enter a date");
            Console.WriteLine("Insert the day");
            bool isNumber1 = int.TryParse(Console.ReadLine(), out int day);

            Console.WriteLine("Insert the month");
            bool isNumber2 = int.TryParse(Console.ReadLine(), out int month);

            Console.WriteLine("Insert the year");
            bool isNumber3 = int.TryParse(Console.ReadLine(), out int year);

            if (!isNumber1 || !isNumber2 || !isNumber3 || year < 4 || month > 12 || month < 1 || day > 31 || day < 1)
            {
                Console.WriteLine("Error, enter the date correctly");
                return;
            }
            if ((day > 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day > 29 && month == 2) || (day > 28 && month == 2 && year % 4 != 0) || (day == 29 && month == 2 && ((year % 4 != 0 || year % 100 == 0) && (year % 400 != 0))))
            {
                Console.WriteLine("Error, enter the date correctly");
                return;
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

            Console.WriteLine("The next day's date is {0}-{1}-{2}", day_next, month_next, year_next);
        }
    }
}

