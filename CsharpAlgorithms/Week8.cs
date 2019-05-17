using System;
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

            while (pos <= fixeLength)
            {
                int medium = pos + (fixeLength - pos) / 2;
                if (x > a[pos])
                    pos = medium + 1;
                else if (x < a[pos])
                    fixeLength = medium - 1;
                else
                    return pos;
            }

            return -1;
        }

        public static bool IsPerfect(int[,] a)
        {
            int row = 0;
            int col = 0;
            int sum_row = 0;
            int sum_col = 0;

            if (a.GetLength(0) != a.GetLength(1))
                return false;

            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum_row += a[i, j];
                    row += a[i + 1, j];

                    if (sum_row != row)
                        return false;
                    sum_row = 0;
                    row = 0;
                }
            }

            for (int i = 0; i < a.GetLength(1) - 1; i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sum_col += a[i, j];
                    col += a[i + 1, j];

                    if (sum_col != col)
                        return false;
                    sum_col = 0;
                    col = 0;
                }
            }

            return true;
        }

        public static bool FindValue(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                        return true;
                }
            }

            return false;
        }

        public static bool ValueBelongs(int value)
        {
            int[,] matriz = new int[value, value];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == value)
                        return true;
                }
            }

            return false;
        }

        public static int[,] PascalTriangle(int n)
        {
            int[,] pascalTriangle = new int[n + 1, n + 1];
            pascalTriangle[0, 0] = 1;
            for (int i = 1, j = 1; i < pascalTriangle.GetLength(0) && j < pascalTriangle.GetLength(1); i++, j++)
            {
                pascalTriangle[i, j] = 1;
                pascalTriangle[0, j] = 1;
            }
            for (int i = 1; i < pascalTriangle.GetLength(1) - 1; i++)
            {
                int cont = 0;
                int sum = 0;
                for (int j = 0; j < pascalTriangle.GetLength(0); j++)
                {
                    if (pascalTriangle[j, i] == 0)
                        break;
                    sum += pascalTriangle[j, i];
                    cont++;
                    if (cont == 2)
                    {
                        pascalTriangle[j, i + 1] = sum;
                        sum = pascalTriangle[j, i];
                        cont = 1;
                    }



                }
            }

            return pascalTriangle;
        }

    }
}
