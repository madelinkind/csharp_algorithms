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

        public static int[] Randomize(int[] inputList, Random r = null)
        {
            if (Object.Equals(r, null))
                r = new Random();

            return Randomize(inputList, 0, r);
        }
        public static int[] Randomize(int[] inputList, int position, Random r)
        {
            if(inputList.Length - 1 == position)
                return inputList;

            int randomIndex = 0;
            int aux = 0;
            randomIndex = r.Next(position, inputList.Length);
            aux = inputList[position];
            inputList[position] = inputList[randomIndex];
            inputList[randomIndex] = aux;

            return Randomize(inputList, position + 1, r);
        }
    }
}
