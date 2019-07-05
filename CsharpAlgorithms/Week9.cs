using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms
{
    public static class Week9
    {
        public static void Hanoi(int n, string origen, string auxiliar, string destino)
        {
            if (n == 1)
                Console.WriteLine("Mueve un disco de {0} a {1}", origen, destino);
            else
            {
                Hanoi(n - 1, origen, destino, auxiliar);
                Console.WriteLine("Mueve un disco de {0} a {1}", origen, destino);
                Hanoi(n - 1, auxiliar, origen, destino);
            }
        }

        public static long Factorial(long N)
        {
            if (N < 1)
                throw new Exception("You must to entry a number greater than 1");
            if (N == 1)
                return 1;
            return N * Factorial(N - 1);
        }

        public static int Fibonacci(int N)
        {
            if (N <= 0)
                throw new Exception("You must to entry a number greater than 1");
            if (N <= 2)
                return 1;
            return Fibonacci(N - 1) + Fibonacci(N - 2);
        }

        public static int Stairs(int tiles)
        {
            return StairInternal(tiles, false);
        }

        public static int StairInternal(int tiles, bool prevWasVertical)
        {
            if (tiles == 0)
                return 1;

            int stairs = StairInternal(tiles - 1, false);
            int stairs1 = StairInternal(tiles - 1, true);
            return stairs + stairs1;
        }

        public static int StairsVersion2(int tiles, bool prevWasVertical)
        {
            if (tiles == 0)
                return 1;

            int stairs = StairsVersion2(tiles - 1, false);
            int stairs1 = (!prevWasVertical) ? StairsVersion2(tiles - 1, true) : 0;

            return stairs + stairs1;
        }

        public static int StairsPrint(int tiles, bool prevWasVertical, string completeStair)
        {
            if (tiles == 0)
            {
                Console.WriteLine("Stair {0}", completeStair);
                return 1;

            }

            int stairs = StairsPrint(tiles - 1, false, completeStair + "-");
            int stairs1 = (!prevWasVertical) ? StairsPrint(tiles - 1, true, completeStair + "|") : 0;

            return stairs + stairs1;
        }

        public static int[] InsertionS(int[] a)
        {
            return InsertionSort(a, 0);
        }

        public static int[] InsertionSort(int[] a, int position)
        {
            if (position == a.Length - 1)
                return a;

            int menor = a[position];
            int mayor = 0;
            int cont = 0;
            for (int i = position + 1; i < a.Length; i++)
            {
                if (a[i] < menor)
                {
                    menor = a[i];
                    cont = i;
                }
            }
            mayor = a[position];
            a[position] = menor;
            a[cont] = mayor;

            return InsertionSort(a, position + 1);
        }

        public static void Find(int[] a, int init, int end)
        {
            FindSmaller(a, 0, a.Length / 2);
        }

        public static int FindSmaller(int[] a, int positionInit, int positionEnd)
        {
            if (positionEnd == a.Length - 1)
            {
                if (a[0] < a[a.Length / 2])
                    return a[0];
                else
                    return a[a.Length / 2];
            }

            int smallerInit = a[0];
            int smallerEnd = a[a.Length / 2];

            if (smallerInit > a[positionInit + 1] && positionInit < a.Length/2 - 1)
            {
                a[0] = a[positionInit + 1];
                a[positionInit + 1] = smallerInit;
            }

            if (smallerEnd > a[positionEnd + 1])
            {
                a[a.Length / 2] = a[positionEnd + 1];
                a[positionEnd + 1] = smallerEnd;
            }

            return FindSmaller(a, positionInit + 1, positionEnd + 1);
        }
    }
}

