using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsharpAlgorithms;

namespace TestCsharpAlgorithms
{
    [TestClass]
    public class TestMixing
    {
        [TestMethod]
        public void WorksForSimpleArrays()
        {
            int[] sorted = Week7.Mixing(new int[] {1}, new int[] {4});

            CollectionAssert.AreEqual(sorted, new int[] {1, 4});
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Left array must not be empty")]
        public void WorksForLeftArrayEmpy()
        {
            int[] sorted = Week7.Mixing(new int[] {}, new int[] {4});
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Right array must not be empty")]
        public void WorksForRightEmptyArray()
        {
            int[] sorted = Week7.Mixing(new int[] {1}, new int[] {});
        }

        [TestMethod]
        public void WorksForLeftArrayLarger()
        {
            int[] sorted = Week7.Mixing(new int[] {1, 27, 45, 100}, new int[] {2, 3, 4});

            CollectionAssert.AreEqual(sorted, new int[] {1, 2, 3, 4, 27, 45, 100});
        }

        [TestMethod]
        public void WorksForRightArrayLarger()
        {
            int[] sorted = Week7.Mixing(new int[] {37, 100}, new int[] {2, 3, 4, 50, 76, 89});

            CollectionAssert.AreEqual(sorted, new int[] {2, 3, 4, 37, 50, 76, 89, 100});
        }
    }
}
