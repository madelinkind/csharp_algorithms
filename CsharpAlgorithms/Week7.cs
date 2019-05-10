using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

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

        /// <summary>
        /// Union two arrays Version 2
        /// </summary>
        public static int[] Union(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                throw new ArgumentException("The arrays are empty");
            if (a == null || b == null)
                throw new ArgumentException("The arrays no exist");

            // create marks (false is if there are no problems, it is true that you can not use)
            bool[] a_marks = new bool[a.Length];
            bool[] b_marks = new bool[b.Length];

            int count_marks_a = 0;
            int count_marks_b = 0;
            int r = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a_marks[i])
                    continue;

                // mark repeated items in a
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        a_marks[j] = true;
                        count_marks_a++;
                    }
                }

                // mark repeated items in b for current value of a
                for (int k = 0; k < b.Length; k++)
                {
                    if (b[k] == a[i])
                    {
                        b_marks[k] = true;
                        count_marks_b++;
                    }
                }
            }

            // mark repeated items in b
            for (int i = 0; i < b.Length; i++)
            {
                if (b_marks[i])
                    continue;

                // check other items in b
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[j] == b[i])
                    {
                        b_marks[j] = true;
                        count_marks_b++;
                    }
                }
            }

            int[] union_a_b = new int[(b.Length - count_marks_b) + (a.Length - count_marks_a)];

            // check other items in b
            for (int i = 0; i < a.Length; i++)
            {
                if (a_marks[i] == false)
                {
                    union_a_b[r] = a[i];
                    r++;
                }
            }
            for (int j = 0; j < b.Length; j++)
            {
                if (b_marks[j] == false)
                {
                    b_marks[j] = true;
                    union_a_b[r] = b[j];
                    r++;
                }
            }
            return union_a_b;
        }

        /// <summary>
        /// Union two arrays
        /// </summary>
        public static int[] UnionVersion2(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                throw new ArgumentException("The arrays are empty");
            if (a == null || b == null)
                throw new ArgumentException("The arrays no exist");

            int count_marks = 0;
            a = AuxiliaryMethods.OrderListLessBigger(a);
            b = AuxiliaryMethods.OrderListLessBigger(b);
            int[] mixing = Mixing(a, b);
            bool[] mixing_marks = new bool[a.Length + b.Length];


            for (int i = 0; i < mixing.Length; i++)
            {
                if (mixing_marks[i])
                    continue;

                // mark repeated items in mixing
                for (int j = i + 1; j < mixing.Length; j++)
                {
                    if (mixing[j] == mixing[i])
                    {
                        mixing_marks[j] = true;
                        count_marks++;
                    }
                }
            }

            int[] union = new int[(a.Length + b.Length) - count_marks];

            for (int k = 0, r = 0; k < mixing.Length; k++)
            {
                if (mixing_marks[k] == false)
                {
                    union[r] = mixing[k];
                    r++;
                }
            }
            return union;
        }

        /// <summary>
        /// Intersection two arrays
        /// </summary>
        public static int[] Intersection(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                throw new ArgumentException("The arrays are empty");
            if (a == null || b == null)
                throw new ArgumentException("The arrays no exist");

            int k = 0;
            int[] intersection = new int[a.Length + b.Length];
            bool[] marks = new bool[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (marks[i] == true)
                    continue;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        marks[j] = true;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j] && marks[i] == false)
                    {
                        intersection[k] = a[i];
                        k++;
                        break;
                    }
                }
            }
            return intersection;
        }

        /// <summary>
        /// Bubble Method
        /// </summary>
        public static int[] BubbleMethod(int[] a)
        {
            int aux = 0;
            bool exchange = false;
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        aux = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = aux;
                        exchange = true;
                    }
                }

                if (exchange == false)
                    break;
            }
            return a;
        }

        /// <summary>
        /// Determine if the number belongs
        /// </summary>
        public static bool Belongs(int[] numbers, int n)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines Average
        /// </summary>
        public static int Average(int[] numbers)
        {
            int longNumbers = numbers.Length;
            int suma = 0;
            int average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                suma += numbers[i];
            }
            average = suma / longNumbers;
            return average;
        }

        /// <summary>
        /// Determines Numbers Greater Than Average
        /// </summary>
        public static int GreaterThanAverage(int[] numbers)
        {
            int average = Average(numbers);
            int countGreaterAverage = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (average < numbers[i])
                    countGreaterAverage++;
            }
            return countGreaterAverage;
        }

        /// <summary>
        /// Evaluates a polynomial
        /// </summary>
        /// <param name="polynomial">polynomial array</param>
        /// <param name="value">int value</param>
        public static double EvaluatePolynomial(int[] polynomial, int value)
        {
            double sum = 0;

            for (int i = 0; i < polynomial.Length; i++)
            {
                if (polynomial[i] != 0)
                    sum += polynomial[i] * Math.Pow(value, i);
            }

            return sum;
        }
        /// <summary>
        /// Add two polynomials
        /// </summary>
        /// <param name="polynomial1">polynomial array</param>
        /// <param name="polynomial2">polynomial array</param>
        /// <returns></returns>
        public static int[] Sum(int[] polynomial1, int[] polynomial2)
        {
            int i;
            int[] sum = new int[Math.Max(polynomial1.Length, polynomial2.Length)];

            for (i = 0; i < polynomial1.Length && i < polynomial2.Length; i++)
            {
                sum[i] = polynomial1[i] + polynomial2[i];
            }

            int spacePol1 = polynomial1.Length - i;
            int spacePol2 = polynomial2.Length - i;

            if (spacePol1 != 0)
                Array.Copy(polynomial1, i, sum, i, spacePol1);
            else if (spacePol2 != 0)
                Array.Copy(polynomial2, i, sum, i, spacePol2);

            return sum;
        }

        /// <summary>
        /// multiply two polynomials
        /// </summary>
        /// <param name="polynomial1">polynomial array</param>
        /// <param name="polynomial2">polynomial array</param>
        /// <returns></returns>
        public static int[] Multiply(int[] polynomial1, int[] polynomial2)
        {
            int[] multiply = new int[(polynomial1.Length + polynomial2.Length) - 1];

            for (int i = 0; i < polynomial1.Length; i++)
            {
                for (int j = 0; j < polynomial2.Length; j++)
                {
                    multiply[i + j] = (polynomial1[i] * polynomial2[j]) + multiply[i + j];
                }
            }

            return multiply;
        }

        public static int Mode(int[] numbers)
        {
            int mode = 0;
            //Contador real
            int count = 0;
            //Contador que guarda en caso de que el contador real se mayor, actualiza el count_fashion
            int count_mode = 0;
            bool[] repeat = new bool[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (repeat[i] == true)
                    continue;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        repeat[j] = true;
                    }
                }
                if (count > count_mode)
                {
                    count_mode = count;
                    mode = numbers[i];
                }
                count = 0;
            }
            return mode;
        }

        public static int[] Insert(int[] a, int pos, int x)
        {

            int value = 0;
            int value1 = 0;
            //i=pos
            int[] insert = new int[a.Length + 1];

            for (int i = pos; i < insert.Length; i++)
            {
                    value1 = a[i];
                    a[i] = value;
                    value = value1;
            }
            return a;
        }

        public static int[] Insert1(int[] a, int pos, int x)
        {

            int value = 0;
            int value1 = 0;
            //i=pos
            //int[] insert = new int[a.Length];
            //Copy , then copy array one to one
            for (int i = pos; i < a.Length; i++)
            {
                value1 = a[i];
                a[i] = value;
                value = value1;
            }
            return a;
        }

        public static void InvierteBloques(int[] a, int k)
        {
            int cont = 0;
            int value = 0;
            int j;
            int p;
            for (int i = 0; i < a.Length; i++)
            {
                j = k;
                p = i;

                if (i == k)
                {
                    while (p <= j)
                    {
                        p = j - p;
                        value = a[p];
                        a[p] = a[j];
                        a[j] = value;
                        p++;
                        j--;
                    }

                }

            }
        }
    }
}
