﻿using System;
using ExtensionMethods;
using System.Diagnostics;


namespace CsharpAlgorithms
{
    public enum NumberSign { POSITIVE, NEGATIVE, ZERO, BLANK_SPACE }
    public enum IsPrime { Prime, NO_PRIME, BLANK_SPACE }
    public static class Week4
    {
        /// <summary>
        ///Determines the factorial of a number 
        /// </summary>
        public static long FactorialNumber(string value)
        {
            long factorial = 1;
            bool isNumber = long.TryParse(value, out long number);

            if (!isNumber || number <= 0)
                throw new ArgumentException("Error, you must enter a number greater than zero");

            while (number != 1)
            {
                factorial = factorial * number;
                number--;
            }
            return factorial;
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        public static bool PrimeNumber(string number)
        {
            int i = 1;
            int cont = 0;
            bool isNumber = int.TryParse(number, out int value);

            if (!isNumber)
                throw new ArgumentException("Error, you must enter whole numbers");

            while (i <= value)
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
        /// Determines how many numbers are negative and how many positive 
        /// </summary>
        public static void PositiveNegativeNumber()
        {
            int positivesCount = 0;
            int negativesCount = 0;

            while (true)
            {
                // determine number sign
                string s = Console.ReadLine();
                NumberSign ns = CountPositiveNegativeNumbers(s);

                //break if blank space
                if (ns == NumberSign.BLANK_SPACE)
                    break;

                // break if number was 0
                if (ns == NumberSign.ZERO)
                    break;

                if (ns == NumberSign.POSITIVE)
                    positivesCount++;
                else if (ns == NumberSign.NEGATIVE)
                    negativesCount++;
            }
            ValueTuple<int, int> countPN = new ValueTuple<int, int>(positivesCount, negativesCount);
        }

        public static (int, int) CountPosNeg(int positivesCount, int negativesCount) => (positivesCount, negativesCount);

        public static NumberSign CountPositiveNegativeNumbers(string value)
        {
            // get integer value from string
            bool isNumber = int.TryParse(value, out int number);

            if (value == string.Empty)
                return NumberSign.BLANK_SPACE;

            // validate that number is integer
            if (!isNumber)
                throw new ArgumentException("Expected int value");

            if (number > 0)
                return NumberSign.POSITIVE;

            if (number < 0)
                return NumberSign.NEGATIVE;

            return NumberSign.ZERO;
        }

        /// <summary>
        /// Determines the numbers primes 
        /// </summary>
        public static void PrimeNumberSeq()
        {
            while (true)
            {
                string value = Console.ReadLine();
                IsPrime number = IsPrimeNumber(value);

                //break if blank space
                if (number == IsPrime.BLANK_SPACE)
                    break;

                if (number == IsPrime.Prime)
                    Console.WriteLine("The number {0} is prime", value);
                else if (number == IsPrime.NO_PRIME)
                    Console.WriteLine("The number {0} is not prime", value);
            }
        }

        public static IsPrime IsPrimeNumber(string value)
        {
            int cont = 0;
            int i = 1;
            // get integer value from string
            bool isNumber = int.TryParse(value, out int number);

            if (value == string.Empty)
                return IsPrime.BLANK_SPACE;

            // validate that number is integer or less than zero
            if (!isNumber || number < 0)
                throw new ArgumentException("Expected int value");

            while (number >= i)
            {
                if (number % i == 0)
                    cont++;
                i++;
            }

            if (cont != 2)
                return IsPrime.NO_PRIME;
            else
                return IsPrime.Prime;
        }

        /// <summary>
        /// Determines the number of strings with greater length.
        /// </summary>
        public static (int, string) LongerLength(string[] list_number)
        {
            int quantity_charact = 0;
            int max_length = 0;
            string characters = string.Empty;
            int count = 0;

            while (list_number[count] != string.Empty)
            {
                int num_characters = list_number[count].Length;
                if (num_characters > quantity_charact)
                {
                    characters = list_number[count];
                    quantity_charact = num_characters;
                    max_length = 1;
                }
                else if (num_characters == quantity_charact)
                {
                    characters = list_number[count];
                    max_length++;
                }
                count++;
            }
            return (max_length, characters);
        }

        /// <summary>
        /// Determines the average of the positive number
        /// </summary>
        public static double AveragePositive(string[] line)
        {
            int i = 0;
            int counter = 0;
            double average = 0.0f;
            double sum = 0.0f;

            while (i < line.Length)
            {
                bool isNumber = double.TryParse(line[i], out double value);

                if (!isNumber)
                    throw new ArgumentException("Expected int value");

                if (value != 0.0f && value > 0.0f)
                {
                    sum += value;
                    counter++;
                }
                else if (value == 0.0f)
                    break;
                i++;
            }
            average = sum / counter;
            return average;
        }


        /// <summary>
        /// Determines if a date is correct
        /// </summary>
        public static bool IsCorrectDate1(string value_day, string value_month, string value_year)
        {
            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            if (!isNumberDay || !isNumberMonth || !isNumberYear || year < 4 || month > 12 || month < 1 || day > 31 || day < 1)
                return false;

            if ((day > 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day > 29 && month == 2) || (day > 28 && month == 2 && year % 4 != 0) || (day == 29 && month == 2 && ((year % 4 != 0 || year % 100 == 0) && (year % 400 != 0))))
                return false;

            else
                return true;
        }

        /// <summary>
        /// Determines the following date 
        /// </summary>
        public static (int, int, int) FollowingDate(string value_day, string value_month, string value_year)
        {
            int month_next = 0;
            int day_next = 0;
            int year_next = 0;

            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            bool isDate = IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

            if (!isDate)
                throw new ArgumentException("Error, incorrect date");

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

                return (day_next, month_next, year_next);
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
        public static (int, int, int) PreviousDate(string value_day, string value_month, string value_year)
        {
            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            bool isDate = IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

            if (!isDate)
                throw new ArgumentException("Error, incorrect date");

            else
            {
                if (day == 1)
                {
                    if (month == 1)
                    {
                        day = 31;
                        month = 12;
                        year = year - 1;
                    }
                    if (month == 4 || month == 6 || month == 9 || month == 11 || month == 2 || month == 8)
                    {
                        month = month - 1;
                        day = 31;
                    }
                    else if (month == 3)
                    {
                        if ((year % 4 != 0 || (year % 100 == 0)) && (year % 400 != 0))
                        {
                            month = 2;
                            day = 28;
                        }
                        else
                        {
                            month = 2;
                            day = 29;
                        }
                    }
                    else if (month != 12 || day != 31)
                    {
                        month = month - 1;
                        day = 30;
                    }
                }
                else
                    day = day - 1;

                return (day, month, year);
            }
        }

        //Method that returns the last day of next month
        public static int LastDayMonthNext(int month, int year)
        {
            int temp_day_next = 0;

            if (month == 1)
            {
                if ((year % 4 != 0 || (year % 100 == 0)) && (year % 400 != 0))
                    temp_day_next = 28;
                else
                    temp_day_next = 29;
            }
            else if (month == 3 || month == 5 || month == 8 || month == 10)
                temp_day_next = 30;
            else
                temp_day_next = 31;

            return temp_day_next;
        }

        /// <summary>
        /// Determines the next date 
        /// </summary>
        public static (int, int, int) IncreaseDate(string value_day, string value_month, string value_year, string count_day)
        {
            int real_day_month_next = 0;
            int leftover_days = 0;
            int last_day_month = 0;

            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);
            bool isNumberCountDays = int.TryParse(count_day, out int amount_days);

            bool isDate = IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

            //Validating date
            if (!isDate || !isNumberCountDays)
                throw new ArgumentException("Error, incorrect date");

            else
            {
                last_day_month = LastDayMonthNext(month - 1, year);
                //Difference between the total days of the month and the number of days
                leftover_days = last_day_month - day;

                if (leftover_days >= amount_days)
                {
                    day = day + amount_days;
                    return (day, month, year);
                }
                real_day_month_next = amount_days - leftover_days;
                last_day_month = LastDayMonthNext(month, year);

                while (true)
                {
                    if (real_day_month_next > last_day_month)
                    {
                        if (month == 12)
                        {
                            month = 0;
                            year++;
                        }
                        month++;
                        real_day_month_next = real_day_month_next - last_day_month;
                        last_day_month = LastDayMonthNext(month, year);
                    }
                    else
                    {
                        if (month == 12)
                        {
                            month = 1;
                            year++;
                            return (real_day_month_next, month, year);
                        }
                        else
                        {
                            month++;
                            return (real_day_month_next, month, year);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Determine the difference of days between two dates
        /// </summary>
        public static int DifferentTwoDays(string value_day, string value_month, string value_year, string value_day2, string value_month2, string value_year2)
        {
            int last_day_month = 0;
            int real_day_year = 0;
            int cont_year_leap = 0;
            int cont_year_no_leap = 0;

            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            bool isNumberDay2 = int.TryParse(value_day2, out int second_day);
            bool isNumberMonth2 = int.TryParse(value_month2, out int second_month);
            bool isNumberYear2 = int.TryParse(value_year2, out int second_year);

            bool isDate = IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);
            bool isDate2 = IsCorrectDate(isNumberDay2, isNumberMonth2, isNumberYear2, second_day, second_month, second_year);

            int temp_year = year + 1;
            int first_latest_year = year;

            //Validating date
            if (!isDate || !isDate2)
                throw new ArgumentException("Error, incorrect date");

            if ((second_day <= day && second_month == month && second_year == year) || (second_year < year) || second_month < month && second_year == year)
                throw new ArgumentException("Error, the first date must be less than the second date");

            else
            {
                if (year == second_year && month == second_month)
                {
                    real_day_year = second_day - day;
                    return real_day_year;

                }

                last_day_month = LastDayMonthNext(month - 1, year);
                real_day_year = last_day_month - day;

                while (temp_year < second_year)
                {
                    if ((temp_year % 4 != 0 || (temp_year % 100 == 0)) && (temp_year % 400 != 0))
                    {
                        temp_year++;
                        cont_year_no_leap++;
                    }
                    else
                    {
                        temp_year++;
                        cont_year_leap++;
                    }
                }

                real_day_year = real_day_year + (cont_year_no_leap * 365 + cont_year_leap * 366);

                while (true)
                {
                    last_day_month = LastDayMonthNext(month, year);
                    real_day_year = real_day_year + last_day_month;
                    month++;
                    if (month == 13 && first_latest_year == year)
                    {
                        month = 1;
                        first_latest_year = second_year;
                    }
                    else if (month + 1 == second_month && first_latest_year == second_year)
                    {
                        real_day_year = real_day_year + second_day;
                        return real_day_year;
                    }
                }
            }
        }

        /// <summary>
        /// Determines the number more big
        /// </summary>
        public static int BiggerNumber(string[] line)
        {
            Console.WriteLine("Enter a sequence of numbers");
            int i = 0;
            int biggerNumber = 0;

            while (i < line.Length)
            {
                bool isNumber = int.TryParse(line[i], out int valueBigger);

                if (!isNumber)
                    throw new ArgumentException("Expected int value");

                else if (valueBigger > biggerNumber)
                    biggerNumber = valueBigger;
                i++;
            }
            return biggerNumber;
        }
    }
}