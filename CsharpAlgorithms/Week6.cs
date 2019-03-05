﻿using System;
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

        //Returns the median of the values ​​of an array
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
    }
}
