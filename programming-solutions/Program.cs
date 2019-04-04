using System;
using System.Diagnostics;

namespace ProgrammingSolutions
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
            //Semana3.FastName();
            //CsharpAlgorithms.Week3.WriteSpeedName();
            #endregion

            #region Ejercicios Semana 4
            //CsharpAlgorithms.Week4.LongerLength("","","");
            //CsharpAlgorithms.Week4.DifferentTwoDates("1", "4", "1933","15", "9", "1934");
            #endregion
            #region Ejercicios Semana 5
            //CsharpAlgorithms.Week4.LongerLength("","","");
            //CsharpAlgorithms.Week5.WeeksDayVersion2("1", "7", "2025");
            #endregion

            #region Ejercicios Semana 6
            //int[] j = new int[8] { 7, 7, 4, 14, 12, 14, 3, 1};
            //CsharpAlgorithms.Week6.Median(j);
            int[] j = new int[8] { 7, 7, 4, 14, 12, 14, 3, 1 };
            CsharpAlgorithms.Week6.RotateRight(j, 25);
            #endregion

            #region Ejercicios Semana 7
            //int[] j = new int[8] { 7, 7, 4, 14, 12, 14, 3, 1};
            //CsharpAlgorithms.Week6.Median(j);
            double[] p = new double[8] { 7, 7, 14, 25, 31, 32, 45, 62 };
            //CsharpAlgorithms.Week7.IterationsSearchBinary(p, 45);
            CsharpAlgorithms.Week7.IterationsSequentialSearch(p, 45);
            #endregion
        }
    }
}