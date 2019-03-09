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
            if (year % 4 == 0 && ((year % 100 != 0) || (year % 400 == 0)))
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

        public static bool FirstDateLess(string value_day, string value_month, string value_year, string value_day2, string value_month2, string value_year2)
        {
            bool isNumberDay = int.TryParse(value_day, out int day);
            bool isNumberMonth = int.TryParse(value_month, out int month);
            bool isNumberYear = int.TryParse(value_year, out int year);

            bool isNumberDay2 = int.TryParse(value_day2, out int second_day);
            bool isNumberMonth2 = int.TryParse(value_month2, out int second_month);
            bool isNumberYear2 = int.TryParse(value_year2, out int second_year);

            if ((second_day <= day && second_month == month && second_year == year) || (second_year < year) || second_month < month && second_year == year)
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Order an array
        /// </summary>
        public static int[] OrderListLessBigger(int[] listNumber)
        {
            int bigger = 0;

            for (int i = 0; i < listNumber.Length; i++)
            {
                for (int j = 0; j < listNumber.Length; j++)
                {
                    if (listNumber[i] > listNumber[j])
                    {
                        bigger = listNumber[i];
                        listNumber[i] = listNumber[j];
                        listNumber[j] = bigger;
                    }
                }
            }
            return listNumber;
        }
    }
}
