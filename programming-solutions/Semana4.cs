using System;
using System.Collections.Generic;

namespace ProgrammingSolutions
{
    static class Semana4
    {
        /// <summary>
        ///Determines the factorial of a number 
        /// </summary>
        public static void FactorialNumber()
        {
            Console.WriteLine("Inserte un número para hallar su factorial");
            string character = Console.ReadLine();
            long number = 0;
            long factorial = 0;
            bool isNumber = long.TryParse(character, out number);

            if (isNumber)
            {
                long entryValue = long.Parse(character);
                factorial = entryValue;

                while (entryValue != 1)
                {
                    factorial = factorial * (entryValue - 1);
                    entryValue--;
                }
                Console.WriteLine("El factorial es {0}", factorial);
            }
            else
                Console.WriteLine("Error, debe entrar un numero. Vuelva a ejecutar el programa");
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        public static void PrimeNumber()
        {
            Console.WriteLine("Inserte un número");
            string character = Console.ReadLine();
            long number = 0;
            bool isNumber = long.TryParse(character, out number);

            if (isNumber)
            {
                int entryValue = int.Parse(character);
                int isPrime = entryValue % 2;
                if (isPrime != 0)
                    Console.WriteLine("El número es primo");
                else
                    Console.WriteLine("El número no es primo");
            }
            else
                Console.WriteLine("Error, debe entrar un numero. Vuelva a ejecutar el programa");
        }

        /// <summary>
        /// Determines how many numbers are negative and how many positive 
        /// </summary>
        public static void PositiveNegativeNumber()
        {
            int postivevalue = 0;
            int negativevalue = 0;
            Console.WriteLine("Entre una secuencia de números");
            string line = String.Empty;

            while ((line = Console.ReadLine()) != String.Empty)
            {
                int number = 0;
                bool isNumber = int.TryParse(line, out number);
                if (isNumber)
                {
                    int valuePN = Int32.Parse(line);
                    if (valuePN < 0)
                        negativevalue++;
                    else
                        postivevalue++;
                }
                else
                    Console.WriteLine("Error, debe entrar un número");
            }
            Console.WriteLine("La cantidad de números positivos entrados: {0}, La cantidad de números negativos entrados: {1}", postivevalue, negativevalue);
        }

        /// <summary>
        /// Determines the numers primes 
        /// </summary>
        public static void PrimeNumberSeq()
        {
            Console.WriteLine("Entre una secuencia de números");
            string line = String.Empty;

            while ((line = Console.ReadLine()) != String.Empty)
            {
                int number = 0;
                bool isNumber = int.TryParse(line, out number);

                if (isNumber)
                {
                    int valuePrime = Int32.Parse(line);
                    if (valuePrime % 2 != 0)
                        Console.WriteLine("El número {0}, es primo", valuePrime);
                    else
                        Console.WriteLine("El número {0}, no es primo", valuePrime);
                }
                else
                    Console.WriteLine("Error, debe entrar un número");
            }
        }

        /// <summary>
        /// Determines the number of strings with greater length.
        /// </summary>
        public static void LongerLength()
        {
            int cont = 0;
            int contador = 0;
            string line = String.Empty;
            string cadena = String.Empty;
            Console.WriteLine("Entre una secuencia de cadenas");

            while ((line = Console.ReadLine()) != String.Empty)
            {
                int valueString = line.Length;
                if (valueString > cont)
                {
                    cadena = line;
                    cont = valueString;
                    contador = 1;
                }
                else if (valueString == cont)
                {
                    cadena = line;
                    contador++;
                }
            }
            Console.WriteLine("El contador {0}, ultima cadena {1}", contador, cadena);
        }

        /// <summary>
        /// Determines the average of the positive number
        /// </summary>
        public static void AveragePositive()
        {
            string line = String.Empty;
            int counter = 0;
            double average = 0;
            double sum = 0;
            double valuePrime = 0;
            Console.WriteLine("Entre una secuencia de números");

            while (true)
            {
                line = Console.ReadLine();
                double number = 0;
                bool isNumber = Double.TryParse(line, out number);
                if (isNumber)
                {
                    valuePrime = Double.Parse(line);
                    if (valuePrime != 0 && valuePrime > 0)
                    {
                        sum += valuePrime;
                        counter++;
                    }
                    else if (valuePrime == 0)
                        break;
                }
                else
                    Console.WriteLine("Entre un número");
            }
            average = sum / counter;
            Console.WriteLine("Promedio:\t{0,8:c}", average);
        }

        /// <summary>
        /// Determines if a date is correct
        /// </summary>
        public static void CorrectDate()
        {
            Console.WriteLine("Entre una fecha");
            Console.WriteLine("Entre dia");
            string day = Console.ReadLine();
            Console.WriteLine("Entre mes");
            string month = Console.ReadLine();
            Console.WriteLine("Entre año");
            string year = Console.ReadLine();

            int number = 0;
            bool isNumberDay = Int32.TryParse(day, out number);
            bool isNumberMonth = Int32.TryParse(month, out number);
            bool isNumberYear = Int32.TryParse(year, out number);

            if (isNumberDay && isNumberMonth && isNumberYear)
            {
                int dayValue = Int32.Parse(day);
                int monthValue = Int32.Parse(month);
                int yearValue = Int32.Parse(year);
                if (dayValue >= 1 && dayValue <= 31 && monthValue >= 1 && monthValue <= 12 && yearValue >= 1300)
                {
                    Console.WriteLine("La fecha es correcta");
                }
                else
                    Console.WriteLine("La fecha no es correcta");
            }
            else
                Console.WriteLine("Error, debe entrar dd/mm/aa. Vuelva a ejecutar el programa");
        }

        /// <summary>
        /// Determines the following date 
        /// </summary>
        public static void FollowingDate()
        {
            int month_next = 0;
            int day_next = 0;
            int year_next = 0;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter a date");
                Console.WriteLine("Enter a day");
                bool isNumberDay = int.TryParse(Console.ReadLine(), out int day);
                Console.WriteLine("Enter a month");
                bool isNumberMonth = int.TryParse(Console.ReadLine(), out int month);
                Console.WriteLine("Enter a year");
                bool isNumberYear = int.TryParse(Console.ReadLine(), out int year);

                bool isDate = IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

                if (!isDate)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error, enter the date correctly");
                }
                else
                {
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
                    Console.WriteLine("");
                    Console.WriteLine("The next day's date is {0}-{1}-{2}", day_next, month_next, year_next);
                    return;
                }
            }
        }

        /// <summary>
        /// Validate date
        /// </summary>
        public static bool IsCorrectDate(bool isNumberDay, bool isNumberMonth, bool isNumberYear, int day, int month, int year)
        {
            if (!isNumberDay || !isNumberMonth || !isNumberYear || year < 4 || month > 12 || month < 1 || day > 31 || day < 1)
                return false;
            if ((day > 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day > 29 && month == 2) || (day > 28 && month == 2 && year % 4 != 0) || (day == 29 && month == 2 && ((year % 4 != 0 || year % 100 == 0) && (year % 400 != 0))))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Determines the previous date
        /// </summary>
        public static void PreviousDate()
        {
            Console.WriteLine("Entre una fecha");
            Console.WriteLine("Entre dia");
            string day = Console.ReadLine();
            Console.WriteLine("Entre mes");
            string month = Console.ReadLine();
            Console.WriteLine("Entre año");
            string year = Console.ReadLine();

            int number = 0;
            bool isNumberDay = Int32.TryParse(day, out number);
            bool isNumberMonth = Int32.TryParse(month, out number);
            bool isNumberYear = Int32.TryParse(year, out number);

            if (isNumberDay && isNumberMonth && isNumberYear)
            {
                int dayValue = Int32.Parse(day);
                int monthValue = Int32.Parse(month);
                int yearValue = Int32.Parse(year);
                if (dayValue >= 1 && dayValue <= 31 && monthValue >= 1 && monthValue <= 12 && yearValue >= 1300)
                {
                    Console.WriteLine("La fecha del día anterior es: {0}/{1}/{2}", dayValue - 1, monthValue, yearValue);
                }
                else
                    Console.WriteLine("La fecha no es correcta");
            }
            else
                Console.WriteLine("Error, debe entrar dd/mm/aa. Vuelva a ejecutar el programa");
        }

        /// <summary>
        /// Determines the next date 
        /// </summary>
        public static void IncreaseDate()
        {
            Console.WriteLine("Entre una fecha");
            Console.WriteLine("Entre dia");
            string day = Console.ReadLine();
            Console.WriteLine("Entre mes");
            string month = Console.ReadLine();
            Console.WriteLine("Entre año");
            string year = Console.ReadLine();
            Console.WriteLine("Entre una cantidad de días");
            string countDays = Console.ReadLine();
            int number = 0;
            bool isNumberDay = Int32.TryParse(day, out number);
            bool isNumberMonth = Int32.TryParse(month, out number);
            bool isNumberYear = Int32.TryParse(year, out number);
            bool isNumberCountDays = Int32.TryParse(countDays, out number);

            if (isNumberDay && isNumberMonth && isNumberYear && isNumberCountDays)
            {
                int dayValue = Int32.Parse(day);
                int monthValue = Int32.Parse(month);
                int yearValue = Int32.Parse(year);
                int countDaysValue = Int32.Parse(countDays);
                int dayRealValue = dayValue + countDaysValue;

                if (dayRealValue >= 1 && dayRealValue <= 31 && monthValue >= 1 && monthValue <= 12 && yearValue >= 1300)
                {
                    Console.WriteLine("La fecha luego de pasar {0} días es: {1}/{2}/{3}", countDaysValue, dayRealValue, monthValue, yearValue);
                }
                else
                    Console.WriteLine("La fecha no es correcta");
            }
            else
                Console.WriteLine("Error, debe entrar dd/mm/aa. Vuelva a ejecutar el programa");
        }

        /// <summary>
        /// Determine the difference of days between two dates
        /// </summary>
        public static void DifferentTwoDays()
        {
            Console.WriteLine("Entre una fecha");
            Console.WriteLine("Entre dia");
            string day = Console.ReadLine();
            Console.WriteLine("Entre mes");
            string month = Console.ReadLine();
            Console.WriteLine("Entre año");
            string year = Console.ReadLine();

            Console.WriteLine("Entre otra fecha");
            Console.WriteLine("Entre dia");
            string day1 = Console.ReadLine();
            Console.WriteLine("Entre mes");
            string month1 = Console.ReadLine();
            Console.WriteLine("Entre año");
            string year1 = Console.ReadLine();

            int number = 0;
            bool isNumberDay = Int32.TryParse(day, out number);
            bool isNumberMonth = Int32.TryParse(month, out number);
            bool isNumberYear = Int32.TryParse(year, out number);

            bool isNumberDay1 = Int32.TryParse(day1, out number);
            bool isNumberMonth1 = Int32.TryParse(month1, out number);
            bool isNumberYear1 = Int32.TryParse(year1, out number);

            if (isNumberDay && isNumberMonth && isNumberYear && isNumberDay1 && isNumberMonth1 && isNumberYear1)
            {
                int dayValue = Int32.Parse(day);
                int monthValue = Int32.Parse(month);
                int yearValue = Int32.Parse(year);

                int dayValue1 = Int32.Parse(day1);
                int monthValue1 = Int32.Parse(month1);
                int yearValue1 = Int32.Parse(year1);

                int differenceDays = 0;

                if (dayValue >= 1 && dayValue <= 31 && monthValue >= 1 && monthValue <= 12 && yearValue >= 1300 && dayValue1 >= 1 && dayValue1 <= 31 && monthValue1 >= 1 && monthValue1 <= 12 && yearValue1 >= 1300)
                {
                    if (dayValue < dayValue1)
                    {
                        differenceDays = dayValue1 - dayValue;
                        Console.WriteLine("Entre las dos fechas hay una diferencia de días de {0}", differenceDays);
                    }
                    else
                        differenceDays = dayValue - dayValue1;
                    Console.WriteLine("Entre las dos fechas hay una diferencia de días de {0}", differenceDays);
                }
                else
                    Console.WriteLine("La fecha no es correcta");
            }
            else
                Console.WriteLine("Error, debe entrar dd/mm/aa. Vuelva a ejecutar el programa");
        }

        /// <summary>
        /// Determines the number more big
        /// </summary>
        public static void BiggerNumber()
        {
            Console.WriteLine("Entre una secuencia de números");
            string line = String.Empty;
            int biggerNumber = 0;

            while ((line = Console.ReadLine()) != String.Empty)
            {
                int number = 0;
                bool isNumber = int.TryParse(line, out number);

                if (isNumber)
                {
                    int valueBigger = Int32.Parse(line);
                    if (valueBigger >= biggerNumber)
                        biggerNumber = valueBigger;
                    else
                        valueBigger = biggerNumber; ;
                }
                else
                    Console.WriteLine("Error, debe entrar un número");
            }
            Console.WriteLine("El mayor numero de la secuencia entrada es: {0}", biggerNumber);
        }
    }
}
