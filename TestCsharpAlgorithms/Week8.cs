using System;
using System.Collections.Generic;
using System.Text;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCsharpAlgorithms
{
    class Week8
    {
        [TestClass]
        public class IsPerfect
        {
            [TestMethod]
            public void RotateLeft3()
            {
                bool esPerfecto = Week8.EsPerfecto(new int[4, 4] { { 2, 2, 2, 2 }, { 2, 2, 2, 2 }, { 2, 2, 2, 2 }, { 2, 2, 2, 2 } });

                Assert.AreEqual(esPerfecto, true);
            }
        }
    }
}
