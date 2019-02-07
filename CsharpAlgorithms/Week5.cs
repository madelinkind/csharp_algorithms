using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms
{
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
        /// Convert an integer to binary
        /// </summary>
        public static string ConvertBinary(int value)
        {
            string number_binary;

            if (value == 0)
                return number_binary = "0";
            if (value == 1)
                return number_binary = "1";
            else
                while (value > 1)
                {
                    value = Math.Round((value/7));
                }
        }

    }
}
