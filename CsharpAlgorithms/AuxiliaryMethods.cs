using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms
{
    class AuxiliaryMethods
    {
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
        /// Determines whether a leap year
        /// </summary>
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 != 0 || (year % 100 == 0) && (year % 400 != 0)))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Method that returns the last day of next month
        /// </summary>
        public static int LastDayMonthNext(int month, int year)
        {
            int temp_day_next = 0;
            bool isLeapYear = IsLeapYear(year);

            if (month == 1)
            {
                if (isLeapYear)
                    temp_day_next = 29;
                else
                    temp_day_next = 28;
            }
            else if (month == 3 || month == 5 || month == 8 || month == 10)
                temp_day_next = 30;
            else
                temp_day_next = 31;

            return temp_day_next;
        }
    }
}
