﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms
{
    public static class Week8
    {
        public static int Posicion(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return i;
            }

            return -1;
        }

        public static int PosBinary(int[] a, int x)
        {
            int pos = 0;
            int fixeLength = a.Length - 1;

            while(pos <= fixeLength)
            {
                int medium = pos + (fixeLength - pos) / 2;
                if (x > a[pos])
                    pos = medium + 1;
                else if (x < a[pos])
                    fixeLength = medium -1;
                else
                    return pos;
            }

            return -1;
        }

        public static bool EsPerfecto(int[,] a)
        {
            int row = 0;
            int col = 0;
            int sum_row = 0;
            int sum_col = 0;

            if (a.GetLength(0) == a.GetLength(1))
            {
                for (int i = 0; i < a.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum_row += a[i, j];
                        row += a[i + 1, j]; 

                        if(sum_row != row)
                            return false;
                        sum_row = 0;
                        row = 0;
                    }
                }

                for (int i = 0; i < a.GetLength(1) -1; i++)
                {
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        sum_col += a[i, j];
                        col += a[i + 1, j]; 

                        if(sum_col != col)
                            return false;
                        sum_col = 0;
                        col = 0;
                    }
                }
            }
            else
                return false;

            return true;
        }    

    }
}
