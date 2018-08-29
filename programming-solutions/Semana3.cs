﻿using System;
using System.Diagnostics;
using ExtensionMethods;

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
                Console.WriteLine("You wrote the third fastest name");
        }
              
        /// <summary>
        /// Determines the type of triangle
        /// </summary>
        public static void TypeTriangle()
        {
            Console.WriteLine("Entre 3 valores enteros");

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
            Console.WriteLine("Entre una fecha");

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            if ((day >= 1 && day <= 31) && (month >= 1 && month <= 12) && (year >= 1880 && year <= 2045))
            {
                Console.WriteLine("El día siguiente es: {0}-{1}-{2}", day + 1, month, year);
            }
            else
                Console.WriteLine("Error, entre correctamente una fecha");
        }
    }
}

