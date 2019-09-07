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
            int[] insertionSort = Week9.InsertionS(new int[] {4, 5, 2, 32, 1, 67, 3});

            CollectionAssert.AreEqual(insertionSort, new int[]{1, 2, 3, 4, 5, 32, 67 });
        }

        [TestClass]
        public class TestFindSmaller
        {
            [TestMethod]
            public void WorkFor1()
            {
                int findSmaller = Week9.FindSmaller(new int[] { 4, -1, -2, -5, 45, 12, 22, 90, -6, 12, 0 }, 0, 5);

                Assert.AreEqual(findSmaller, -6);
            }
        }
    }

     [TestClass]
    public class TestRandomize
    {
        [TestMethod]
        public void WorkFor1()
        {
            int[] randomize = Week9.Randomize(new int[] {4, 5, 2, 32, 1, 67, 3}, new Random(0));

            CollectionAssert.AreEqual(randomize, new int[]{67, 4, 5, 2, 1, 3, 32 });
        }
    }

    [TestClass]
    public class Test
    {
        [TestMethod]
        public void WorkFor1()
        {
            int findSmaller = Week9.FindSmallerVersion2(new int[] { 4, 5, 2, 32, 1, 67, 3 }, 0, 6);

            Assert.AreEqual(findSmaller, 1);
        }
    }

     [TestClass]
    public class TestMergeSort
    {
        [TestMethod]
        public void WorkFor1()
        {
            int[] merge_sort = Week9.MergeSort(new int[] { 4, 5, 2, 32, 1, 67, 3 });

            CollectionAssert.AreEqual(merge_sort, new int[] { 1, 2, 3, 4, 5, 32, 67});
        }
    }

    [TestClass]
    public class TestUbicaReinas
    {
        [TestMethod]
        public void WorkFor1()
        {
            bool ubica_reinas = Week9.UbicaReinas(new bool[8, 8] {
                {false,false,false,false,false,false,false,false}, 
                {false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false}}, 8);

            Assert.AreEqual(ubica_reinas, true);
        }

        [TestMethod]
        public void WorkFor2()
        {
            bool ubica_reinas = Week9.UbicaReinas(new bool[3, 3] {
                {false,false,false}, 
                {false,false,false},
                {false,false,false}
               }, 1);

            Assert.AreEqual(ubica_reinas, true);
        }
    }
}