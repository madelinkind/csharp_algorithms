using System;
using ExtensionMethods;
using System.Diagnostics;
using System.Collections.Generic;

namespace CsharpAlgorithms
{
    public enum NumberSign { POSITIVE, NEGATIVE, ZERO, BLANK_SPACE }
    public enum IsPrime { Prime, NO_PRIME, BLANK_SPACE }
    public static class Week4
    {
        /// <summary>
        ///Determines the factorial of a number 
        /// </summary>
        public static void FactorialNumber()
        {
            Console.WriteLine("Insert a number to find its factorial");
            string number = Console.ReadLine();

            long result = FactorialNumber(number);

            Console.WriteLine("The factorial is {0}", result);
        }

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
        public static void Prime()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            bool isPrime = PrimeNumber(number);

            if (!isPrime)
                Console.WriteLine("The number is not prime");
            else
                Console.WriteLine("The number is prime");
        }

        public static bool PrimeNumber(string number)
        {
            bool isNumber = int.TryParse(number, out int value);

            if (!isNumber)
                throw new ArgumentException("Error, you must enter whole numbers");

            int i = 2;
            double root_value = Math.Sqrt(value);
            int root_value_int = (int)root_value;

            while (i <= root_value_int)
            {
                if (value % i == 0)
                    return false;
                i++;
            }
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
        }

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
            // get integer value from string
            bool isNumber = int.TryParse(value, out int number);

            if (value == string.Empty)
                return IsPrime.BLANK_SPACE;

            // validate that number is integer or less than zero
            if (!isNumber || number < 0)
                throw new ArgumentException("Expected int value");

            int i = 2;
            double root_value = Math.Sqrt(number);
            int root_value_int = (int)root_value;

            while (i <= root_value_int)
            {
                if (number % i == 0)
                    return IsPrime.NO_PRIME;
                i++;
            }
            return IsPrime.Prime;
        }

        /// <summary>
        /// Determines the number of strings with greater length.
        /// </summary>
        public static void LongerLength()
        {
            Console.WriteLine("Enter a string sequence");
            string line = string.Empty;
            List<string> list_string = new List<string>();

            while ((line = Console.ReadLine()) != string.Empty)
                list_string.Add(line);

            var longer = LongerLength(list_string);
            Console.WriteLine("Number of chains with the same length: {0}, Last chain with greater length is: {1}", longer.countChains, longer.chainGreaterLength);
        }

        public static (int countChains, string chainGreaterLength) LongerLength(List<string> list_number)
        {
            int quantity_charact = 0;
            int max_length = 0;
            string characters = string.Empty;
            int count = 0;

            while (list_number.Count > count)
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
        public static void ListNumber()
        {
            Console.WriteLine("Enter a integer sequence");
            string line = string.Empty;
            List<string> list_integer = new List<string>();

            while ((line = Console.ReadLine()) != string.Empty)
                list_integer.Add(line);

            double averagePositive = AveragePositive(list_integer);
            Console.WriteLine("The average of the positive numbers is: {0}", averagePositive);
        }

        public static double AveragePositive(List<string> line)
        {
            int i = 0;
            int counter = 0;
            double average = 0.0f;
            double sum = 0.0f;

            while (i < line.Count)
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
        public static void Date()
        {
            Console.WriteLine("Write day:");
            string day = Console.ReadLine();

            Console.WriteLine("Write month:");
            string month = Console.ReadLine();

            Console.WriteLine("Write year:");
            string year = Console.ReadLine();

            // determine if a date is correct
            bool result = IsCorrectDate(day, month, year);

            // output relevant information
            Console.WriteLine("The date is correct?", result);
        }

        public static bool IsCorrectDate(string value_day, string value_month, string value_year)
        {
            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            bool isDate = AuxiliaryMethods.IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

            if (!isDate)
                return false;

            bool isLeapYear = AuxiliaryMethods.IsLeapYear(year);

            if ((day > 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day > 29 && month == 2) || (day > 28 && month == 2 && year % 4 != 0) || (day == 29 && month == 2 && isLeapYear))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Determines the following date 
        /// </summary>
        public static void GetNextDay()
        {
            Console.WriteLine("Write day:");
            string day = Console.ReadLine();

            Console.WriteLine("Write month:");
            string month = Console.ReadLine();

            Console.WriteLine("Write year:");
            string year = Console.ReadLine();

            // determine next day
            var result = FollowingDate(day, month, year);

            // output relevant information
            Console.WriteLine("Next day date is: {0}/{1}/{2}", result.day, result.month, result.year);
        }

        public static (int day, int month, int year) FollowingDate(string value_day, string value_month, string value_year)
        {
            int month_next = 0;
            int day_next = 0;
            int year_next = 0;

            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            bool isDate = AuxiliaryMethods.IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

            if (!isDate)
                throw new ArgumentException("Error, incorrect date");

            bool isLeapYear = AuxiliaryMethods.IsLeapYear(year);

            if ((day == 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day == 29 && month == 2) || ((day == 28 && month == 2) && !isLeapYear) || day == 31)
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

        /// <summary>
        /// Determines the previous date
        /// </summary>
        public static void ShowPreviusDate()
        {
            Console.WriteLine("Write day:");
            string day = Console.ReadLine();

            Console.WriteLine("Write month:");
            string month = Console.ReadLine();

            Console.WriteLine("Write year:");
            string year = Console.ReadLine();

            // determine previous day
            var result = PreviousDate(day, month, year);

            // output relevant information
            Console.WriteLine("Previous day date is: {0}/{1}/{2}", result.day, result.month, result.year);
        }

        public static (int day, int month, int year) PreviousDate(string value_day, string value_month, string value_year)
        {
            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            bool isDate = AuxiliaryMethods.IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

            if (!isDate)
                throw new ArgumentException("Error, incorrect date");

            bool isLeapYear = AuxiliaryMethods.IsLeapYear(year);

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
                    if (!isLeapYear)
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

            bool isDate = AuxiliaryMethods.IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

            //Validating date
            if (!isDate || !isNumberCountDays)
                throw new ArgumentException("Error, incorrect date");

            last_day_month = AuxiliaryMethods.LastDayMonthNext(month - 1, year);
            //Difference between the total days of the month and the number of days
            leftover_days = last_day_month - day;

            if (leftover_days >= amount_days)
            {
                day = day + amount_days;
                return (day, month, year);
            }
            real_day_month_next = amount_days - leftover_days;
            last_day_month = AuxiliaryMethods.LastDayMonthNext(month, year);

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
                    last_day_month = AuxiliaryMethods.LastDayMonthNext(month, year);
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

        /// <summary>
        /// Determine the difference of days between two dates
        /// </summary>
        public static void ShowDifferentTwoDates()
        {
            Console.WriteLine("Write first date");
            Console.WriteLine("Write day:");
            string first_day = Console.ReadLine();

            Console.WriteLine("Write month:");
            string first_month = Console.ReadLine();

            Console.WriteLine("Write year:");
            string first_year = Console.ReadLine();

            Console.WriteLine("Write second date");
            Console.WriteLine("Write day:");
            string second_day = Console.ReadLine();

            Console.WriteLine("Write month:");
            string second_month = Console.ReadLine();

            Console.WriteLine("Write year:");
            string second_year = Console.ReadLine();

            // determine the difference in days between two dates
            int result = DifferentTwoDates(first_day, first_month, first_year, second_day, second_month, second_year);

            // output relevant information
            Console.WriteLine("The difference in days between two dates is:{0}", result);
        }

        public static int DifferentTwoDates(string value_day, string value_month, string value_year, string value_day2, string value_month2, string value_year2)
        {
            int util_day = 0;
            int util_month = 0;
            int util_year = 0;
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

            bool isDate = AuxiliaryMethods.IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);
            bool isDate2 = AuxiliaryMethods.IsCorrectDate(isNumberDay2, isNumberMonth2, isNumberYear2, second_day, second_month, second_year);

            //Validating date
            if (!isDate || !isDate2)
                throw new ArgumentException("Error, incorrect date");

            if ((second_day <= day && second_month == month && second_year == year) || (second_year < year) || second_month < month && second_year == year)
            {   //In case the initial date is greater than the final date, it is reversed.
                util_day = day;
                util_month = month;
                util_year = year;
                day = second_day;
                month = second_month;
                year = second_year;
                second_day = util_day;
                second_month = util_month;
                second_year = util_year;
            }

            int temp_year = year + 1;
            int first_latest_year = year;

            if (year == second_year && month == second_month)
            {
                real_day_year = second_day - day;
                return real_day_year;
            }

            last_day_month = AuxiliaryMethods.LastDayMonthNext(month - 1, year);
            real_day_year = last_day_month - day;

            while (temp_year < second_year)
            {
                bool isLeapYear = AuxiliaryMethods.IsLeapYear(temp_year);

                if (isLeapYear)
                {
                    temp_year++;
                    cont_year_leap++;
                }
                else
                {
                    temp_year++;
                    cont_year_no_leap++;
                }
            }

            real_day_year = real_day_year + (cont_year_no_leap * 365 + cont_year_leap * 366);

            while (true)
            {
                if (month != 12)
                {
                    last_day_month = AuxiliaryMethods.LastDayMonthNext(month, year);
                    real_day_year = real_day_year + last_day_month;
                    month++;
                }
                if (month == 12 && first_latest_year == year)
                {
                    month = 1;
                    year = second_year;
                    first_latest_year = year;
                }
                if ((month == second_month-1|| month == second_month )&& first_latest_year == second_year)
                {
                    real_day_year = real_day_year + second_day;
                    return real_day_year;
                }
                else if (month == 1 && first_latest_year == second_year)
                {
                    last_day_month = AuxiliaryMethods.LastDayMonthNext(month-1, year);
                    real_day_year = real_day_year + last_day_month;
                }
            }
        }

        /// <summary>
        /// Determines the number more big
        /// </summary>
        public static void ShowBiggerNumber()
        {
            Console.WriteLine("Enter a sequence of numbers");
            string line = string.Empty;
            List<string> list_number = new List<string>();

            while ((line = Console.ReadLine()) != string.Empty)
                list_number.Add(line);

            int biggerNumber = BiggerNumber(list_number);
            Console.WriteLine("The average of the positive numbers is: {0}", biggerNumber);
        }

        public static int BiggerNumber(List<string> line)
        {
            int i = 0;
            int biggerNumber = 0;

            while (i < line.Count)
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

       public static int[] ReverseBlockVers1(int[] a, int k)
       {
           int value = 0;
           int rest = a.Length % k;
           for (int i = 0; i < a.Length - rest; i += k)
           {
               int lb = i;
               int ub = lb + k;
               for (int j = i; j < (lb + ub)/2; j++)
               {
                    int id = j - i;  
                    value = a[j];
                    a[j] = a[ub - 1 - id];
                    a[ub - 1 - id] = value;  
               }
           }

           return a;
       } 

        public static int[] ReverseBlockVers2(int[] a, int k)
       {
           int value = 0;
           int rest = a.Length % k;
           for (int i = 0; i < a.Length; i += k)
           {
                int lb = i;
                // int ub = lb + k;
                // int m = Math.Min(a.Length, ub);
                // if(a.Length < ub)
                //     ub = lb + rest;

                int ub = Math.Min(lb + k, a.Length);
                for (int j = i; j < (lb + ub)/2; j++)
                {
                    int id = j - i;  
                    value = a[j];
                    a[j] = a[ub - 1 - id];
                    a[ub - 1 - id] = value;
                }
           }

           return a;
       } 
    }
}
