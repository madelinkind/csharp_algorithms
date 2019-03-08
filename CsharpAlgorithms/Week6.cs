using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms
{
    public static class Week6
    {
        /// <summary>
        ///  Returns the bigger element of an array
        /// </summary>
        public static int ElementBigger(int[] listNumber)
        {
            int bigger = 0;

            for (int i = 0; i < listNumber.Length; i++)
            {
                if (listNumber[i] > bigger)
                {
                    bigger = listNumber[i];
                }
            }
            return bigger;
        }

        /// <summary>
        /// Returns the first largest value of an array
        /// </summary>
        public static int PositionFirstNumberBigger(int[] listNumber)
        {
            int position = 0;
            int bigger = 0;

            for (int i = 0; i < listNumber.Length; i++)
            {
                if (listNumber[i] > bigger)
                {
                    bigger = listNumber[i];
                    position = i;
                }
            }
            return position;
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
        /// <summary>
        /// Returns the median of the values ​​of an array
        /// </summary>
        public static int Median(int[] listInteger)
        {
            int median = 0;

            int[] listOrder = Week6.OrderListLessBigger(listInteger);
            int countElements = listOrder.Length;
            int quotient = countElements / 2;

            if (countElements % 2 == 0)
                median = (listOrder[quotient] + listOrder[(quotient - 1)]) / 2;
            else
                median = listInteger[quotient];
            return median;
        }
        /// <summary>
        /// Determines the second largest number
        /// </summary>
        public static int SecondLargest(int[] listNumber)
        {
            int[] listOrder = Week6.OrderListLessBigger(listNumber);
            int secondLargest = listOrder.Length - 2;
            return secondLargest;
        }

        /// <summary>
        /// Returns another array with the elements inverted
        /// </summary>
        public static int[] Inverted(int[] listNumber)
        {
            int j = 0;
            int sizeList = listNumber.Length;
            int[] inverted = new int[sizeList];
            for (int i = sizeList - 1; i < 0; i--)
            {
                inverted[j] = listNumber[i];
                j++;
            }
            return inverted;
        }
        /// <summary>
        /// Convert an array of integers to a string
        /// </summary>
        public static string ConvertString(int[] numberList)
        {
            string integerToString = "";

            for (int i = 0; i < numberList.Length; i++)
            {
                integerToString += numberList[i];
            }
            return integerToString;
        }
        /// <summary>
        /// Returns another array rotated n positions
        /// </summary>
        public static int[] RotateRight(int[] listNumber, int n)
        {
            int[] rotate = new int[listNumber.Length];
            int positionInitial = 0;

            if (n >= listNumber.Length)
                n = n % listNumber.Length;

            int countRotRight = n;

            for (int i = 0; i < listNumber.Length; i++)
            {
                if (countRotRight < listNumber.Length)
                {
                    rotate[countRotRight] = listNumber[i];
                    countRotRight++;
                }
                else if (positionInitial < n)
                {
                    rotate[positionInitial] = listNumber[i];
                    positionInitial++;
                }
            }
            return rotate;
        }
    }
}

