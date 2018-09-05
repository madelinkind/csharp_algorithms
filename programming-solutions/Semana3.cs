using System;
using System.Diagnostics;

namespace ProgrammingSolutions
{
    static class Semana3
    {
        /// <summary>
        /// Find the largest of three numbers
        /// </summary>
        public static void Mayor()
        {
            Console.WriteLine("Teclea un primer numero ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("Teclea un segundo numero ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Teclea un tercer numero ");
            int m = int.Parse(Console.ReadLine());

            if ((j >= k) && (j >= m))
                Console.WriteLine("El mayor es {0}", j);
            else if ((k >= j) && (k >= m))
                Console.WriteLine("El mayor es {0}", k);
            else
                Console.WriteLine("El mayor es {0}", m);
        }

        /// <summary>
        /// Find the largest of three numbers using Math.Max
        /// </summary>
        public static void MayorFunction()
        {
            Console.WriteLine("Teclea un primer numero ");
            bool jIsNumber = int.TryParse(Console.ReadLine(), out int j);

            Console.WriteLine("Teclea un segundo numero ");
            bool kIsNumber = int.TryParse(Console.ReadLine(), out int k);

            Console.WriteLine("Teclea un tercer numero ");
            bool mIsNumber = int.TryParse(Console.ReadLine(), out int m);

            // check that all values are integer
            if (!jIsNumber || !kIsNumber || !mIsNumber)
            {
                Console.WriteLine("You must type valid integer numbers");
                return;
            }
            else
            {
                // get maximum of the three numbers
                int mayor = Math.Max(Math.Max(j, k), m);
                Console.WriteLine("El mayor es {0}", mayor);
            }
        }

        /// <summary>
        /// Determines the writing speed
        /// </summary>
        public static void Speed()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Teclee su nombre?");

            crono.Start();
            string name = Console.ReadLine();
            crono.Stop();

            int charactersCount = name.Length;
            double elapsedSeconds = crono.ElapsedMilliseconds / 1000.0;
            double charactersPerSecond = charactersCount / elapsedSeconds;

            if (charactersPerSecond > 2)
                Console.WriteLine("Usted es rápido");
            else if (charactersPerSecond >= 1 && charactersPerSecond <= 2)
                Console.WriteLine("Usted es regular");
            else
                Console.WriteLine("Usted es lento");
        }

        /// <summary>
        /// Determines which of the three names were written faster
        /// </summary>
        public static void FastName()
        {
            Stopwatch crono = new Stopwatch();

            Console.WriteLine("Teclee su nombre tres veces?");

            crono.Start();
            string firstName = Console.ReadLine();
            crono.Stop();
            long timeFirstName = crono.ElapsedMilliseconds;

            crono.Reset();
            crono.Start();
            string secondName = Console.ReadLine();
            crono.Stop();
            long timeSecondName = crono.ElapsedMilliseconds;

            crono.Reset();
            crono.Start();
            string thirdName = Console.ReadLine();
            crono.Stop();
            long timeThirdName = crono.ElapsedMilliseconds;

            if (firstName == secondName && secondName == thirdName)
            {
                if (timeFirstName <= timeSecondName && timeFirstName <= timeThirdName)
                    Console.WriteLine("Usted exscribió el primer nombre más rápido");
                else if (timeSecondName <= timeThirdName)
                    Console.WriteLine("Usted exscribió el segundo nombre más rápido");
                else
                    Console.WriteLine("Usted exscribió el tercer nombre más rápido");
            }
            else
                Console.WriteLine("Error, has tecleado mal alguno de los nombres. Vuélva a ejecutar el programa");
        }

        /// <summary>
        /// Determines the type of triangle
        /// </summary>
        public static void TypeTriangle()
        {
            Console.WriteLine("Entre 3 valores enteros");

            int side = int.Parse(Console.ReadLine());
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());

            if (side > 0 && side1 > 0 && side2 > 0)
            {

                if (side == side1 && side == side2)
                    Console.WriteLine("Es un triangulo Equilátero");
                else if (side != side1 && side1 != side2 && side != side2)
                    Console.WriteLine("Es un triángulo Escaleno");
                else
                    Console.WriteLine("Es un triángulo Isósceles");
            }
            else
                Console.WriteLine("No es posible formar un triángulo");
        }

        /// <summary>
        /// Orders from least to greatest and determines the average between the 3 numbers
        /// </summary>
        public static void OrderAvrg()
        {
            float average = 0;
            Console.WriteLine("Entre 3 valores enteros a ordenar");

            int value = int.Parse(Console.ReadLine());
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());

            if (value <= value1 && value <= value2)
            {
                if (value1 <= value2)
                    Console.WriteLine("{0},{1},{2}", value, value1, value2);
                else
                    Console.WriteLine("{0},{1},{2}", value, value2, value1);
            }
            else if (value1 <= value && value1 <= value2)
            {
                if (value <= value2)
                    Console.WriteLine("{0},{1},{2}", value1, value, value2);
                else
                    Console.WriteLine("{0},{1},{2}", value1, value2, value);
            }
            else if (value2 <= value && value2 <= value1)
            {
                if (value <= value1)
                    Console.WriteLine("{0},{1},{2}", value2, value, value1);
                else
                    Console.WriteLine("{0},{1},{2}", value2, value1, value);
            }
            average = (value + value1 + value2) / 3;
            Console.WriteLine("{0}", average);
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        public static void PrimeNumber()
        {
            Console.WriteLine("Entre un número que se encuentre en el rango del 1 al 100");
            int valor = int.Parse(Console.ReadLine());

            if (valor >= 1 && valor <= 100)
            {
                int rest = valor % 2;
                if (rest != 0)
                    Console.WriteLine("El número es primo");
                else
                    Console.WriteLine("El número no es primo");
            }
            else
                Console.WriteLine("Error, entró un número fuera del rango indicado. Vuelva a ejecutar el programa.");
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
