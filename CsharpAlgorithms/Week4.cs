using System;
using ExtensionMethods;
using System.Diagnostics;


namespace CsharpAlgorithms
{
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
                    {
                        day = day - 1;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("The after day's date is {0}-{1}-{2}", day, month, year);
                    return;
                }
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
        public static void IncreaseDate()
        {
            int real_day_month_next = 0;
            int leftover_days = 0;
            int last_day_month = 0;

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
                Console.WriteLine("Between the number of days you want to increase to date");
                bool isNumberCountDays = int.TryParse(Console.ReadLine(), out int amount_days);

                bool isDate = IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);

                //Validating date
                if (!isDate || !isNumberCountDays)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error, enter the date correctly");
                }
                else
                {
                    last_day_month = LastDayMonthNext(month - 1, year);
                    leftover_days = last_day_month - day;

                    if (leftover_days >= amount_days)
                    {
                        day = day + amount_days;
                        Console.WriteLine("The after day's date is {0}/{1}/{2}", day, month, year);
                        return;
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
                                Console.WriteLine("The after day's date is {0}/{1}/{2}", real_day_month_next, month, year);
                                return;
                            }
                            else
                            {
                                month++;
                                Console.WriteLine("The after day's date is {0}/{1}/{2}", real_day_month_next, month, year);
                                return;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Determine the difference of days between two dates
        /// </summary>
        public static void DifferentTwoDays()
        {
            int last_day_month = 0;
            int real_day_year = 0;
            int cont_year_leap = 0;
            int cont_year_no_leap = 0;

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

                Console.WriteLine("");
                Console.WriteLine("Enter a date mayor que la primera fecha entrada");
                Console.WriteLine("Enter a day");
                bool isNumberDay2 = int.TryParse(Console.ReadLine(), out int second_day);
                Console.WriteLine("Enter a month");
                bool isNumberMonth2 = int.TryParse(Console.ReadLine(), out int second_month);
                Console.WriteLine("Enter a year");
                bool isNumberYear2 = int.TryParse(Console.ReadLine(), out int second_year);

                bool isDate = IsCorrectDate(isNumberDay, isNumberMonth, isNumberYear, day, month, year);
                bool isDate2 = IsCorrectDate(isNumberDay2, isNumberMonth2, isNumberYear2, second_day, second_month, second_year);

                int temp_year = year + 1;
                int first_latest_year = year;

                //Validating date
                if (!isDate || !isDate2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error, enter the date correctly");
                }
                if ((second_day <= day && second_month == month && second_year == year) || (second_year < year) || second_month < month && second_year == year)
                {
                    Console.WriteLine("Error, the first date must be less than the second date");
                }

                else
                {
                    if (year == second_year && month == second_month)
                    {
                        real_day_year = second_day - day;
                        Console.WriteLine("The difference of days between both dates is: {0}", real_day_year);
                        return;
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
                            Console.WriteLine("The difference of days between both dates is: {0}", real_day_year);
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Determines the number more big
        /// </summary>
        public static void BiggerNumber()
        {
            Console.WriteLine("Enter a sequence of numbers");
            string line = string.Empty;
            int biggerNumber = 0;

            while ((line = Console.ReadLine()) != string.Empty)
            {
                bool isNumber = int.TryParse(line, out int valueBigger);

                if (!isNumber)
                {
                    Console.WriteLine("Error, you must enter a number");
                }
                else if (valueBigger > biggerNumber)
                {
                    biggerNumber = valueBigger;
                }
            }
            Console.WriteLine("The largest number of the input sequence is: {0}", biggerNumber);
        }
    }
}
