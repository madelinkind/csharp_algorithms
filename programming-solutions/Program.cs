using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace programming_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicios Semana 1
            #endregion

            #region Ejercicios Semana 2
            #endregion

            #region Ejercicios Semana 3
            Semana3.NextDay();
            #endregion
         
            #region Ejercicios Semana 4
            
            #endregion

            //NameAgeOfUser();
            //DoubleName();
            //TotalTimeDoubleName();
            //TotalTimeDoubleName1();

            // take least time that took the user to write his name
            //shorterTime();
        }

        /// <summary>
        /// Handles user's name and age
        /// </summary>
        static void NameAgeOfUser()
        {

            Console.WriteLine("Hola, teclee su nombre y edad por favor");
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Hola " + nombre + ". Felicidades por tus " + edad + " años de edad.");
            System.Console.Read();
        }

        static void DoubleName()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Hola, teclee su nombre dos veces por favor");
            for (int i = 0; i < 2; i++)
            {
                crono.Start();
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine();
                crono.Stop();
                Console.WriteLine("Te has demorado " + crono.ElapsedMilliseconds + "ms en teclear tu nombre");
            }

            System.Console.Read();

        }

        static void TotalTimeDoubleName1()
        {
            float totalTime = 0;
            float averageTime = 0;
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Hola, teclee su nombre dos veces por favor");
            crono.Start();
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            crono.Stop();
            float time = crono.ElapsedMilliseconds;
            crono.Start();
            Console.WriteLine("Nombre:");
            string nombre1 = Console.ReadLine();
            crono.Stop();
            float time1 = crono.ElapsedMilliseconds;
            totalTime = time + time1;
            averageTime = totalTime / 2;
            Console.WriteLine("Te has demorado un total de " + totalTime + " ms en escribir dos veces tu nombre");
            Console.WriteLine("Te has demorado un promedio de " + averageTime + " ms en escribir dos veces tu nombre");
            System.Console.Read();
        }
        static void TotalTimeDoubleName()
        {
            float totalTime = 0;
            float averageTime = 0;
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Hola, teclee su nombre dos veces por favor");

            for (int i = 0; i < 2; i++)
            {
                crono.Start();
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine();
                crono.Stop();
                float time = crono.ElapsedMilliseconds;
                totalTime += time;
            }
            averageTime = totalTime / 2;
            Console.WriteLine("Te has demorado un total de " + totalTime + " ms en escribir dos veces tu nombre");
            Console.WriteLine("Te has demorado un promedio de " + averageTime + " ms en escribir dos veces tu nombre");
            System.Console.Read();
        }

        static void ShorterTime()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Hola, teclee su nombre dos veces por favor");
            crono.Start();
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            crono.Stop();
            float time = crono.ElapsedMilliseconds;
            crono.Start();
            Console.WriteLine("Nombre:");
            string nombre1 = Console.ReadLine();
            crono.Stop();
            float time1 = crono.ElapsedMilliseconds;
            float shorter = Math.Min(time, time1);
            Console.Clear();
            Console.WriteLine("El tiempo menor es " + shorter);
            System.Console.Read();

        }

    }
}