using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms
{
    public static class Week9
    {
        public static void Hanoi(int n, string origen, string auxiliar, string destino)
        {
            if(n == 1)
                Console.WriteLine("Mueve un disco de {0} a {1}", origen, destino);
            else
            {
                Hanoi(n - 1, origen, destino, auxiliar);
                Console.WriteLine("Mueve un disco de {0} a {1}", origen, destino);
                Hanoi(n - 1, auxiliar, origen, destino);
            }
        }
    }
}
