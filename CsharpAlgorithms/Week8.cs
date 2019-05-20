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
                pascalTriangle[i, 0] = 1;
            }
            for (int i = 1; i < pascalTriangle.GetLength(0) - 1; i++)
            {
                int cont = 0;
                int sum = 0;
                for (int j = 0; j < pascalTriangle.GetLength(1); j++)
                {
                    if (pascalTriangle[i, j] == 0)
                        break;
                    sum += pascalTriangle[i, j];
                    cont++;
                    if (cont == 2)
                    {
                        pascalTriangle[i + 1, j] = sum;
                        sum = pascalTriangle[i, j];
                        cont = 1;
                    }
                }
            }

            return pascalTriangle;
        }

        public static int[,] PascalTriangle2(int n)
        {
            int[,] pascalTriangle = new int[n + 1, n + 1];
            pascalTriangle[0, 0] = 1;
            for (int i = 1; i < pascalTriangle.GetLength(0); i++)
            {
                pascalTriangle[i, 0] = 1;
                for (int j = 1; j <= i; j++)
                    pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
            }

            return pascalTriangle;
        }

        public static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < a.GetLength(1); j++)
                    row += (j == a.GetLength(1) - 1) ? $"{a[i, j]}" : $"{a[i, j]},";

                Console.WriteLine(row);
            }
        }

        public static void PrintMatrix2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int[] row = new int[a.GetLength(1)];
                for (int j = 0; j < a.GetLength(1); j++)
                    row[j] = a[i, j];

                Console.WriteLine(string.Join(",", row));
            }
        }

        public static int[,] Mirror(int[,] a, bool horizontal)
        {
            int[,] mirror = new int[a.GetLength(0), a.GetLength(1)];
            int dimention = a.GetLength(0) / 2;
            if (a.GetLength(0) - 1 % 2 != 0)
                dimention = (a.GetLength(0) / 2) + 1;
            for (int i = 0; i < dimention; i++)
            {
                int aux = 0;
                int aux1 = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i != dimention)
                    {
                        aux = a[i, j];
                        aux1 = a[a.GetLength(0) - 1 - i, j];
                        mirror[i, j] = aux1;
                        mirror[a.GetLength(0) - 1 - i, j] = aux;
                    }
                    else
                    {
                        aux = a[i, j];
                        mirror[i, j] = aux;
                    }
                }
            }

            return mirror;
        }

        public static int[,] Mirror2(int[,] a, bool horizontal)
        {
            int[,] mirror = new int[a.GetLength(0), a.GetLength(1)];
            Array.Copy(a, 0, mirror, 0, a.Length);

            if (horizontal == true)
            {
                for (int i = 0; i < a.GetLength(0) / 2; i++)
                {
                    int aux = 0;
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        aux = mirror[i, j];
                        mirror[i, j] = mirror[a.GetLength(0) - 1 - i, j];
                        mirror[a.GetLength(0) - 1 - i, j] = aux;
                    }
                }
            }
            else
            {
                for (int j = 0; j < a.GetLength(1) / 2; j++)
                {
                    int aux = 0;
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        aux = mirror[i, j];
                        mirror[i, j] = mirror[i, a.GetLength(1) - 1 - j];
                        mirror[i, a.GetLength(1) - 1 - j] = aux;
                    }
                }
            }

            return mirror;
        }

        public static bool ValidDimension(int i, int j, int nRows, int nCols)
        {
            if (i >= nRows || j >= nCols || i < 0 || j < 0)
                return false;

            return true;
        }

        public static bool FourOnLine(bool[,] a, int n = 4)
        {
            int[] Dx = new int[4] { 1, 0, 1, -1};
            int[] Dy = new int[4] { 0, 1, 1, 1};

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int d = 0; d < Dx.Length; d++)
                    {
                        int id_i = i;
                        int id_j = j;
                        int cont = 1;
                        for (int k = 0; k < n - 1; k++)
                        {
                            id_i += Dx[d];
                            id_j += Dy[d];
                            bool posicionValid = ValidDimension(id_i, id_j, a.GetLength(0), a.GetLength(1));
                            if (!posicionValid)
                                break;
                            if (a[i, j] == a[id_i, id_j])
                                cont++;
                            else
                                break;
                        }
                        if (cont == n)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}
