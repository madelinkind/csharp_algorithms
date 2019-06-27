using System;
using System.Collections.Generic;
using System.Text;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCsharpAlgorithms
{
    [TestClass]
    public class TestFactorial
    {
        [TestMethod]
        public void WorkFor1()
        {
            long factorial = Week9.Factorial(1);

            Assert.AreEqual(factorial, 1);
        }
    }

    [TestClass]
    public class TestFibonacci
    {
        [TestMethod]
        public void WorkFor1()
        {
            long fibonacci = Week9.Fibonacci(3);

            Assert.AreEqual(fibonacci, 2);
        }
    }

    [TestClass]
    public class TestStairs
    {
        [TestMethod]
        public void WorkFor1()
        {
            long stairs = Week9.StairsPrint(3, true, "");

            Assert.AreEqual(stairs, 3);
        }
    }

    [TestClass]
    public class TestInsertionSort
    {
        [TestMethod]
        public void WorkFor1()
        {
            int[] insertionSort = Week9.InsertionSort(new int[] {4, 5, 2}, 0);

            Assert.AreEqual(insertionSort, 2);
        }
    }
}