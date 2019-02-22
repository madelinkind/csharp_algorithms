using System;
using System.Collections.Generic;
using System.Text;


namespace CsharpAlgorithms
{
    enum Dia { Lunes = 1, Martes = 2, Miercoles = 3, Jueves = 4, Viernes = 5, Sabado = 6, Domingo = 0 }
    public static class Week5
    {
        /// <summary>
        /// Calculate if a number is perfect
        /// </summary>

        public static void PerfectNumber(int number)
        {
            int sum = 1;
            int i = 2;
            while (i < number && sum < number)
            {
                if (number % i == 0)
                    sum += i;
                i++;

                if (sum == number)
                {
                    Console.WriteLine("The number {0} is perfect", number);
                    return;
                }
            }

            Console.WriteLine("The number {0} is not perfect", number);
            return;
        }

        /// <summary>
        /// List all the prime numbers in an interval
        /// </summary>
        public static void IntervalPrimeNumber(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("{0}", i);
            }
        }

        /// <summary>
        /// List all the prime numbers, writing 5 numbers in each line
        /// </summary>
        public static void IntervalPrimeNumberJump(int start, int end)
        {
            int cont = 0;

            for (int i = start; i <= end; i++)
            {

                if (i % 2 != 0 && cont < 5)
                {
                    cont++;
                    Console.WriteLine("{0}", i);
                }
                else if (i % 2 != 0 && cont >= 5)
                {
                    cont = 0;
                    Console.WriteLine("");
                }
            }
        }

        /// <summary>
        /// convert an integer to binary
        /// </summary>
        public static string ConvertBinary(int value)
        {
            string binary = "";

            if (value < 0)
                throw new ArgumentException("You must enter a positive number");

            if (value == 0)
                return binary = "0";

            while (value != 0)
            {
                binary += value % 2 + binary;
                value = value / 2;
            }

            return binary;
        }

        /// <summary>
        /// convert a integer to a roman number
        /// </summary>
        public static string ConvertToRoman(int number)
        {
            int unitMeasurement = 3;
            double exponent = 0;
            int quotient = 0;
            int result = 0;
            int rest = 0;
            string roman = "";

            if (number < 1 || number > 3999)
            {
                Console.WriteLine("Error, you must enter an entire number in the range from 1 to 3999");
                return roman;
            }

            Dictionary<int, string> d = new Dictionary<int, string>()
            {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
                {7, "VII"},
                {8, "VIII"},
                {9, "IX"},
                {10, "X"},
                {20, "XX"},
                {30, "XXX"},
                {40, "XL"},
                {50, "L"},
                {60, "LX"},
                {70, "LXX"},
                {80, "LXXX"},
                {90, "XC"},
                {100, "C"},
                {200, "CC"},
                {300, "CCC"},
                {400, "CD"},
                {500, "D"},
                {600, "DC"},
                {700, "DCC"},
                {800, "DCCC"},
                {900, "CM"},
                {1000, "M"},
                {2000, "MM"},
                {3000, "MMM"}
            };

            while (true)
            {
                exponent = Math.Pow(10, unitMeasurement);
                quotient = (int)(number / exponent);
                rest = (int)(number % exponent);

                if (quotient == 0)
                {
                    unitMeasurement--;
                    exponent = Math.Pow(10, unitMeasurement);
                }

                else
                {
                    result = (int)(quotient * exponent);
                    roman += d[result];
                    number -= result;
                    unitMeasurement--;
                }

                if (number == 0)
                    break;
            }
            return roman;
        }

        public static int WeeksDay(int day, int month, int year)
        {
            int monthDictionary;
            Dictionary<int, int> weeks = new Dictionary<int, int>()
            {
                {1, 0},
                {2, 3},
                {3, 3},
                {4, 6},
                {5, 1},
                {6, 4},
                {7, 6},
                {8, 2},
                {9, 5},
                {10,0},
                {11,3},
                {12,5}
            };

            monthDictionary = weeks[month];
            if ((year % 4 == 0 || (year % 100 != 0)) && (year % 400 != 0) && month >= 3)
            {
                if (month == 4 || month == 7)
                    monthDictionary = 0;
                else
                    monthDictionary = monthDictionary + 1;
            }
                day = (((year - 1) % 7) + (((year - 1) / 4 - (3 * ((year - 1) / 100 + 1) / 4)) % 7) + (monthDictionary + day % 7)) % 7;
            if (day > 0)
                return day;
            else
                return 7;
        }
    }
}
