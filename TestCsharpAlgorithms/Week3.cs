using System;
using System.Collections.Concurrent;
using CsharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCsharpAlgorithms
{
    [TestClass]
    public class Week3
    {

        [TestMethod]
        public void MaximumNumber_ThreeIntegerNumber_ReturnMaximumNumber()
        {
            int result = Semana3.MaximumNumber("4", "5", "9");

            Assert.AreEqual(9, result);
        }
       
    }
}
