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
                    fixeLength = medium - 1;
                else if (numSearch > listOrder[medium])
                    fixeLength = medium + 1;
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
            int fixeLength = listOrder.Length;
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
                    fixeLength = medium - 1;
                }
                else if (numSearch > listOrder[medium])
                {
                    numbIteration++;
                    fixeLength = medium + 1;
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
    }
}
