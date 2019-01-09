using System;

namespace ProgrammingSolutions
{
    static class Semana4
    {
        /// <summary>
        ///Determines the factorial of a number 
        /// </summary>
        public static void FactorialNumber()
        {
            long factorial = 1;
            Console.WriteLine("Insert a number to find its factorial");
            bool isNumber = long.TryParse(Console.ReadLine(), out long number);

            if (!isNumber || number <= 0)
            {
                Console.WriteLine("Error, you must enter a number greater than zero. Run the program again");
                return;
            }
            while (number != 1)
            {
                factorial = factorial * number;
                number--;
            }
            Console.WriteLine("The factorial is {0}", factorial);
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        public static void PrimeNumber()
        {
            int i = 1;
            int cont = 0;
            Console.WriteLine("Enter a number");
            bool isNumber = int.TryParse(Console.ReadLine(), out int value);

            if (!isNumber)
            {
                Console.WriteLine("Error, you must enter whole numbers. Run the program again");
                return;
            }
            while (i <= value)
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
        /// Determines how many numbers are negative and how many positive 
        /// </summary>
        public static void PositiveNegativeNumber()
        {
            int positive_values = 0;
            int negative_values = 0;
            Console.WriteLine("Enter a sequence of numbers");
            string line = string.Empty;

            while ((line = Console.ReadLine()) != string.Empty)
            {
                bool isNumber = int.TryParse(line, out int valuePn);
                if (isNumber)
                {
                    if (valuePn < 0)
                        negative_values++;
                    else
                        positive_values++;
                }
                else
                    Console.WriteLine("Error, you must enter a number ");
            }
            Console.WriteLine("The number of positive numbers entered: {0}. The number of negative numbers entered: {1}", positive_values, negative_values);
        }

        /// <summary>
        /// Determines the numers primes 
        /// </summary>
        public static void PrimeNumberSeq()
        {
            Console.WriteLine("Enter a sequence of numbers");
            string line = string.Empty;

            while ((line = Console.ReadLine()) != string.Empty)
            {
                int i = 1;
                int cont = 0;
                bool isNumber = int.TryParse(line, out int value_prime);

                if (!isNumber || value_prime < 0)
                {
                    Console.WriteLine("Error, you must enter a number");
                }
                else
                {
                    while (value_prime >= i)
                    {
                        if (value_prime % i == 0)
                            cont++;
                        i++;
                    }
                    if (cont != 2)
                        Console.WriteLine("The number {0}, is not prime", value_prime);
                    else
                        Console.WriteLine("The number {0}, is prime", value_prime);
                }
            }
        }

        /// <summary>
        /// Determines the number of strings with greater length.
        /// </summary>
        public static void LongerLength()
        {
            int quantity_charact = 0;
            int max_length = 0;
            string line = string.Empty;
            string characters = string.Empty;
            Console.WriteLine("Enter a string sequence");

            while ((line = Console.ReadLine()) != string.Empty)
            {
                int num_characters = line.Length;
                if (num_characters > quantity_charact)
                {
                    characters = line;
                    quantity_charact = num_characters;
                    max_length = 1;
                }
                else if (num_characters == quantity_charact)
                {
                    characters = line;
                    max_length++;
                }
            }
            Console.WriteLine("Number of chains with the same maximum length: {0}, last chain with the longest: {1}", max_length, characters);
        }

        /// <summary>
        /// Determines the average of the positive number
        /// </summary>
        public static void AveragePositive()
        {
            string line = string.Empty;
            int counter = 0;
            double average = 0.0f;
            double sum = 0.0f;

            Console.WriteLine("Enter a sequence of numbers and if you want to finish dial 0");

            while (true)
            {
                line = Console.ReadLine();
                bool isNumber = double.TryParse(line, out double value);
                if (isNumber)
                {
                    if (value != 0.0f && value > 0.0f)
                    {
                        sum += value;
                        counter++;
                    }
                    else if (value == 0.0f)
                        break;
                }
                else
                    Console.WriteLine("Error, you must enter numbers, if you want to exit, dial 0");
            }
            average = sum / counter;
            Console.WriteLine("Promedio:\t{0,8:c}", average);
        }

        /// <summary>
        /// Determines if a date is correct
        /// </summary>
        public static void CorrectDate()
        {
            Console.WriteLine("Enter a date");
            Console.WriteLine("Enter a day");
            bool isNumberDay = Int32.TryParse(Console.ReadLine(), out int day);

            Console.WriteLine("Enter a month");
            bool isNumberMonth = int.TryParse(Console.ReadLine(), out int month);

            Console.WriteLine("Enter a year");
            bool isNumberYear = int.TryParse(Console.ReadLine(), out int year);

            if (!isNumberDay || !isNumberMonth || !isNumberYear || year < 4 || month > 12 || month < 1 || day > 31 || day < 1)
            {
                Console.WriteLine("Error, incorrect date");
                return;
            }
            if ((day > 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day > 29 && month == 2) || (day > 28 && month == 2 && year % 4 != 0) || (day == 29 && month == 2 && ((year % 4 != 0 || year % 100 == 0) && (year % 400 != 0))))
            {
                Console.WriteLine("Error, incorrect date");
                return;
            }
            else
            {
                Console.WriteLine("Date correct ");
            }
        }

        /// <summary>
        /// Determines the following date 
        /// </summary>
        public static void FollowingDate()
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
                    Console.WriteLine("La fecha del día siguiente es: {0}/{1}/{2}", dayValue + 1, monthValue, yearValue);
                }
                else
                    Console.WriteLine("La fecha no es correcta");
            }
            else
                Console.WriteLine("Error, debe entrar dd/mm/aa. Vuelva a ejecutar el programa");
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
