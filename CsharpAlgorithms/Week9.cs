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
            if (inputList.Length - 1 == position)
                return inputList;

            int randomIndex = 0;
            int aux = 0;
            randomIndex = r.Next(position, inputList.Length);
            aux = inputList[position];
            inputList[position] = inputList[randomIndex];
            inputList[randomIndex] = aux;

            return Randomize(inputList, position + 1, r);
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

            if (smallerInit > a[positionInit + 1] && positionInit < a.Length / 2 - 1)
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

        public static void FindVersion2(int[] a)
        {
            FindSmallerVersion2(a, 0, a.Length - 1);
        }

        public static int FindSmallerVersion2(int[] a, int lower, int upper)
        {
            if (upper <= lower)
                return a[lower];

            int half = (lower + upper) / 2;

            int minLeftHalf = FindSmallerVersion2(a, lower, half);
            int minRightHalf = FindSmallerVersion2(a, half + 1, upper);

            return Math.Min(minLeftHalf, minRightHalf);
        }

        public static int PortalFindElement(int[] a, int value)
        {
            return FindElement(a, 0, a.Length - 1, value);
        }

        public static int FindElement(int[] a, int lower, int uper, int value)
        {
            if (lower >= uper)
                return -1;
            int half = (lower + uper) / 2;

            if (a[half] == value)
                return half;

            if (a[half] > value)
                uper = half - 1;
            else
                lower = half + 1;

            return FindElement(a, lower, uper, value);
        }

        public static int[] MergeSort(int[] a)
        {
            if (a.Length == 1)
                return a;

            int half = a.Length / 2;
            int[] left = new int[half];
            int[] right = new int[a.Length - half];

            Array.Copy(a, left, half);
            left = MergeSort(left);

            Array.Copy(a, half, right, 0, a.Length - half);
            right = MergeSort(right);

            int[] merge_sort = Week7.Mixing(left, right);

            return merge_sort;
        }

        public static bool Amenaza(bool[,] tablero, int fila, int columna)
        {
            //Verificar si hay alguna reina en la misma fila o columna
            for(int i = 0; i < tablero.GetLength(0); i++)
            {
                if(tablero[fila, i] || tablero[i, columna])
                    return true;
            }
            //Diagonal arriba a la izquierda
            for (int f = fila, c= columna; f >= 0 && c >= 0; f--, c--)
            {
                if(tablero[f,c])
                    return true;
            }
            //Diagonal abajo a la izquierda
            for (int f = fila, c= columna; f < tablero.GetLength(0) && c >= 0; f++, c--)
            {
                if(tablero[f,c])
                    return true;
            }
            //Notar q no es necesario revisar las diagonales a la derecha
            //pues no hay reinas ubicadas aun en las columnas de la derecha

            return false;
        }

        public static bool UbicaReinas(bool[,] tablero, int reinas)
        {
            //Condicion de parada cuando ya no queden reinas por ubicar
            if(reinas == 0) 
                return true;

            int columna = tablero.GetLength(0) - reinas;

            //Ciclo por las filas para recorrer la columna
            for(int fila = 0; fila < tablero.GetLength(0); fila++)
            {
                //verificar si la reina en la ubicacion no amenaza las anteriores
                if(!Amenaza(tablero, fila, columna))
                {
                    // Ubicar la reina (hacer una accion X)
                    tablero[fila, columna] = true;

                    //Intentar ubicar las restantes (llamar recursivo para seguir resolviendo)
                    if(UbicaReinas(tablero, reinas - 1))
                        // si encuentra solucion, retorna el resultado
                        return true;

                    /*
                        Si llegas a aqui es que no encontraste solucion.
                        Lo siguiente es revertir la accion X
                        En este caso revertirla significa quitar
                        la reina de la posicion (fila, columna)
                    */
                    //Volver atras y reubicar las reinas
                    tablero[fila, columna] = false;
                }
            }

            return false;// No se pudieron reubicar las reinas
        }
    }
}

