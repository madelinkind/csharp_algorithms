using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
                throw new ArgumentException("The array no exist");
            if (listOrder.Length == 0)
                throw new ArgumentException("The array is empty");

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
                throw new ArgumentException("The array no exist");
            if (listOrder.Length == 0)
                throw new ArgumentException("The array is empty");

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
                throw new ArgumentException("The array no exist");
            if (listOrder.Length == 0)
                throw new ArgumentException("The array is empty");

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
                throw new ArgumentException("The arrays are empty");
            if (a == null || b == null)
                throw new ArgumentException("The arrays no exist");

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

        /// <summary>
        /// Union two arrays
        /// </summary>
        public static int[] UnionArray(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                throw new ArgumentException("The arrays are empty");
            if (a == null || b == null)
                throw new ArgumentException("The arrays no exist");
            var list = a.Union(b);
            int[] resultUnion = list.ToArray();
            return resultUnion;
        }

        public static int[] Union123(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                throw new ArgumentException("The arrays are empty");
            if (a == null || b == null)
                throw new ArgumentException("The arrays no exist");

            int[] unionAB = new int[a.Length + b.Length];
            int[] mixingAB = new int[a.Length + b.Length];
            int k = 0;
            int p = 0;
            int j;
            int c;
            int r;
            for (int i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        break;
                }
                    if (j == a.Length && a[i] != a[j - 1])
                    {
                        unionAB[k] = a[i];
                        k++;
                    }
            }

            for (int i = 0; i < b.Length; i++)
            {
                for (c = i + 1; c < b.Length; c++)
                {
                    if (b[i] == b[c])
                        break;

                }
                if (c == b.Length && b[i] != b[c - 1])
                {
                        unionAB[k] = b[i];
                        k++;
                }
            }

            for (int i = 0; i < unionAB.Length; i++)
            {
                for (r = i + 1; r < unionAB.Length; r++)
                {
                    if (unionAB[i] == unionAB[r])
                        break;

                }
                if (r == unionAB.Length && unionAB[i] != unionAB[r-1])
                {
                        mixingAB[p] = unionAB[i];
                        p++;
                }
            }
            return mixingAB;
        }
    }
}
