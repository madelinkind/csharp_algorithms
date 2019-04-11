using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms
{
    public static class Week7
    {
        /// <summary>
        /// Binary search
        /// </summary>
        public static int SearchBinary(double[] listOrder, double numSearch)
        {
            int post = 0;
            int fixeLength = listOrder.Length;

            if (listOrder == null)
                throw new Exception("The array no exist");
            if (listOrder.Length == 0)
                throw new Exception("The array is empty");

            while (post < fixeLength)
            {
                int medium = post + (fixeLength - post) / 2;

                if (numSearch < listOrder[medium])
                    post = medium - 1;
                else if (numSearch > listOrder[medium])
                    post = medium + 1;
                else
                    return medium;
            }
            return -1;
        }

        /// <summary>
        /// Number of iterations for the Binary search method 
        /// </summary>
        public static int IterationsSearchBinary(double[] listOrder, double numSearch)
        {
            int post = 0;
            int fixeLength = listOrder.Length - 1;
            int numbIteration = 0;

            if (listOrder == null)
                throw new Exception("The array no exist");
            if (listOrder.Length == 0)
                throw new Exception("The array is empty");

            while (post < fixeLength)
            {
                int medium = post + (fixeLength - post) / 2;

                if (numSearch < listOrder[medium])
                {
                    numbIteration++;
                    post = medium - 1;
                }
                else if (numSearch > listOrder[medium])
                {
                    numbIteration++;
                    post = medium + 1;
                }
                else
                {
                    numbIteration++;
                    return numbIteration;
                }
            }
            return numbIteration;
        }

        /// <summary>
        /// Number of iterations for the sequential search method
        /// </summary>
        public static int IterationsSequentialSearch(double[] listOrder, double numSearch)
        {
            int numbIteration = 0;

            if (listOrder == null)
                throw new Exception("The array no exist");
            if (listOrder.Length == 0)
                throw new Exception("The array is empty");

            for (int i = 0; i < listOrder.Length; i++)
            {
                if (listOrder[i] == numSearch)
                {
                    numbIteration++;
                    return numbIteration;
                }
                else
                    numbIteration++;
            }
            return numbIteration;
        }

        /// <summary>
        /// Mix two arrays
        /// </summary>
        public static int[] Mixing(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                throw new Exception("The arrays are empty");
            if (a == null || b == null)
                throw new Exception("The arrays no exist");

            int countMixing = 0;
            int lengthMixing = a.Length + b.Length;
            int[] mixing = new int[lengthMixing];
            int i;
            int j;

            for (i = 0, j = 0; i < a.Length && j < b.Length; countMixing++)
            {
                if (a[i] <= b[j])
                {
                    mixing[countMixing] = a[i];
                    i++;
                }
                else
                {
                    mixing[countMixing] = b[j];
                    j++;
                }
            }

            int spaceA = a.Length - i;
            int spaceB = b.Length - j;
            if (spaceA != 0)
                Array.Copy(a, i, mixing, countMixing, spaceA);
            else
                Array.Copy(b, j, mixing, countMixing, spaceB);

            return mixing;
        }
    }
}
