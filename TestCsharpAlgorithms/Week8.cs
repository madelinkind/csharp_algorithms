using System;
using System.Collections.Generic;
using System.Text;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCsharpAlgorithms
{
    [TestClass]
    public class IsPerfect
    {
        [TestMethod]
        public void TestIsPerfect()
        {
            bool esPerfecto = Week8.IsPerfect(new int[4, 4] { { 2, 2, 2, 2 }, { 2, 2, 2, 2 }, { 2, 2, 2, 2 }, { 2, 2, 2, 2 } });

            Assert.AreEqual(esPerfecto, true);
        }
    }

    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void RotateLeft3()
        {
            int[,] pascalTriangle = Week8.PascalTriangle(4);

            Assert.AreEqual(pascalTriangle, new int[5, 5] { { 1, 0, 0, 0,0 },
                                                            { 1, 1, 0, 0,0 },
                                                            { 1, 2, 1, 0,0 },
                                                            { 1, 3, 3, 1,0 },
                                                            { 1, 4, 6, 4,1 } });
        }
    }
}

