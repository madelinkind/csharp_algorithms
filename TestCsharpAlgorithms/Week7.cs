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

    [TestClass]
    public class TestIntersection
    {
        [TestMethod]
        public void WorksForSimpleArrays()
        {
            int[] sorted = Week7.Intersection(new int[] { 1 }, new int[] { 1 });

            CollectionAssert.AreEqual(sorted, new int[] { 1, 0 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Left array must not be empty")]
        public void WorksForLeftArrayEmpy()
        {
            int[] sorted = Week7.Intersection(new int[] { }, new int[] { 4 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Right array must not be empty")]
        public void WorksForRightEmptyArray()
        {
            int[] sorted = Week7.Intersection(new int[] { 1 }, new int[] { });
        }

        [TestMethod]
        public void WorksForLeftArrayLarger()
        {
            int[] sorted = Week7.Intersection(new int[] { 1, 1, 45, 3 }, new int[] { 1, 4, 3 });

            CollectionAssert.AreEqual(sorted, new int[] { 1, 3, 0, 0, 0, 0, 0 });
        }

        [TestMethod]
        public void WorksForRightArrayLarger()
        {
            int[] sorted = Week7.Intersection(new int[] { 3, 100 }, new int[] { 2, 3, 4, 50, 76, 89 });

            CollectionAssert.AreEqual(sorted, new int[] { 3, 0, 0, 0, 0, 0, 0, 0 });
        }

        [TestMethod]
        public void WorksForNoElementInaCommon()
        {
            int[] sorted = Week7.Intersection(new int[] { 5, 100 }, new int[] { 2, 3, 4, 50, 76, 89 });

            CollectionAssert.AreEqual(sorted, new int[] { 0, 0, 0, 0, 0, 0, 0, 0 });
        }
    }

    [TestClass]
    public class Sum
    {
        [TestMethod]
        public void WorksForNoElementInaCommon()
        {
            int[] sum = Week7.Sum(new int[] { 2, 5 }, new int[] { 2, 3, 4, 50, 76, 89 });

            CollectionAssert.AreEqual(sum, new int[] {4, 8, 4, 50, 76, 89});
        }
    }

    [TestClass]
    public class InsertVers1
    {
        [TestMethod]
        public void WorksForLeftArrayLast()
        {
            int[] insert = Week7.InsertVers1(new int[] { 2, 3, 4, 50, 76, 89 }, 5, 10);

            CollectionAssert.AreEqual(insert, new int[] {2, 3, 4, 50,76, 10});
        }

        [TestMethod]
        public void WorksForLeftArrayFirst()
        {
            int[] insert = Week7.InsertVers2(new int[] { 2, 3, 4, 50, 76, 89 }, 0, 10);

            CollectionAssert.AreEqual(insert, new int[] {10, 2, 3, 4, 50,76});
        }
        [TestMethod]
        public void WorksForLeftArrayMiddle()
        {
            int[] insert = Week7.InsertVers2(new int[] { 2, 3, 4, 50, 76, 89 }, 0, 10);

            CollectionAssert.AreEqual(insert, new int[] {10, 2, 3, 4, 50,76});
        }
    }

    [TestClass]
    public class InsertVers2
    {
        [TestMethod]
        public void WorksForLeftArrayLast()
        {
            int[] insert = Week7.InsertVers1(new int[] { 2, 3, 4, 50, 76, 89 }, 5, 10);

            CollectionAssert.AreEqual(insert, new int[] {2, 3, 4, 50,76, 10});
        }

        [TestMethod]
        public void WorksForLeftArrayFirst()
        {
            int[] insert = Week7.InsertVers2(new int[] { 2, 3, 4, 50, 76, 89 }, 0, 10);

            CollectionAssert.AreEqual(insert, new int[] {10, 2, 3, 4, 50,76});
        }

        [TestMethod]
        public void WorksForLeftArrayMiddle()
        {
            int[] insert = Week7.InsertVers2(new int[] { 2, 3, 4, 50, 76, 89 }, 0, 10);

            CollectionAssert.AreEqual(insert, new int[] {10, 2, 3, 4, 50,76});
        }
    }

    [TestClass]
    public class ReverseBlock
    {
        [TestMethod]
        public void WorksForLeftArrayMiddle()
        {
            int[] insert = Week7.ReverseBlok(new int[] { 2, 3, 4, 50, 76, 89, 10, 32 }, 4);

            CollectionAssert.AreEqual(insert, new int[] {50, 4, 3, 2, 32, 10, 89, 76});
        }
    }

    [TestClass]
    public class ReverseBlock1
    {
        [TestMethod]
        public void WorksForLeftArrayMiddle()
        {
            int[] insert = Week4.ReverseBlockVers1(new int[] { 2, 3, 4, 50, 76, 89, 10, 32 }, 4);

            CollectionAssert.AreEqual(insert, new int[] {50, 4, 3, 2, 32, 10, 89, 76});
        }

        [TestMethod]
        public void WorksForLeftArrayPar()
        {
            int[] insert = Week4.ReverseBlockVers1(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 89 }, 4);

            CollectionAssert.AreEqual(insert, new int[] {50, 4, 3, 2, 32, 10, 89, 76, 12, 89});
        }

        [TestMethod]
        public void WorksForLeftArrayImpar()
        {
            int[] insert = Week4.ReverseBlockVers1(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 3);

            CollectionAssert.AreEqual(insert, new int[] {4,3,2,89,76,50,12,32,10,54,89});
        }
    }

    [TestClass]
    public class ReverseBlock2
    {
        [TestMethod]
        public void WorksForLeftArrayMiddle()
        {
            int[] insert = Week4.ReverseBlockVers2(new int[] { 2, 3, 4, 50, 76, 89, 10, 32 }, 4);

            CollectionAssert.AreEqual(insert, new int[] {50, 4, 3, 2, 32, 10, 89, 76});
        }

        [TestMethod]
        public void WorksForLeftArrayPar()
        {
            int[] insert = Week4.ReverseBlockVers2(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 89, 32 }, 4);

            CollectionAssert.AreEqual(insert, new int[] {50, 4, 3, 2, 32, 10, 89, 76, 32,89, 12});
        }

        [TestMethod]
        public void WorksForLeftArrayImpar()
        {
            int[] insert = Week4.ReverseBlockVers2(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 3);

            CollectionAssert.AreEqual(insert, new int[] {4,3,2,89,76,50,12,32,10,89,54 });
        }
    }

    [TestClass]
    public class Rotate
    {
        [TestMethod]
        public void RotateRight3()
        {
        int[] rotated = Week7.RotateRight(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 3);

        CollectionAssert.AreEqual(rotated, new int[] {12,54,89,2, 3, 4, 50, 76, 89, 10, 32});
        }

        [TestMethod]
        public void RotateRight5()
        {
        int[] rotated = Week7.RotateRight(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 5);

        CollectionAssert.AreEqual(rotated, new int[] {10, 32, 12, 54, 89,  2, 3, 4, 50, 76, 89});
        }
    }
    [TestClass]
    public class RotateVers2
    {
        [TestMethod]
        public void RotateRight3()
        {
        int[] rotated = Week7.RotateRightVers2(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 3);

        CollectionAssert.AreEqual(rotated, new int[] {12,54,89,2, 3, 4, 50, 76, 89, 10, 32});
        }

        [TestMethod]
        public void RotateRight5()
        {
        int[] rotated = Week7.RotateRightVers2(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 5);

        CollectionAssert.AreEqual(rotated, new int[] {10, 32, 12, 54, 89,  2, 3, 4, 50, 76, 89});
        }
    }

    [TestClass]
    public class RotateRight
    {
        [TestMethod]
        public void RotateRight3()
        {
        int[] rotated = Week7.RotateRight(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 3);

        CollectionAssert.AreEqual(rotated, new int[] {12,54,89,2, 3, 4, 50, 76, 89, 10, 32});
        }

        [TestMethod]
        public void RotateRight5()
        {
        int[] rotated = Week7.RotateRight(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 5);

        CollectionAssert.AreEqual(rotated, new int[] {10, 32, 12, 54, 89,  2, 3, 4, 50, 76, 89});
        }
    }

    [TestClass]
    public class RotateLeft
    {
        [TestMethod]
        public void RotateLeft3()
        {

        int[] rotated = Week7.RotateLeftVers2(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 3);

        CollectionAssert.AreEqual(rotated, new int[] {50, 76, 89, 10, 32, 12, 54, 89,2,3,4});

        }

        [TestMethod]
        public void RotateLeft5()
        {

        int[] rotated = Week7.RotateLeftVers2(new int[] { 2, 3, 4, 50, 76, 89, 10, 32, 12, 54, 89 }, 5);

        CollectionAssert.AreEqual(rotated, new int[] {89, 10, 32, 12, 54, 89,  2, 3, 4, 50, 76});

        }
    }

    [TestClass]
    public class SearchBinary
    {
        [TestMethod]
        public void RotateLeft3()
        {

            int rotated = Week7.SearchBinary(new double[] { 2, 3, 4, 10, 25, 30, 31, 32, 40, 45, 50 }, 51);

            Assert.AreEqual(rotated, -1);

        }

        [TestMethod]
        public void RotateLeft5()
        {

            int rotated = Week7.SearchBinary(new double[] { 2, 3, 4, 10, 25, 30, 31, 32, 40, 45, 50 }, 45);

            Assert.AreEqual(rotated, 9);

        }
    }

    [TestClass]
    public class SearchWeek8
    {
        [TestMethod]
        public void RotateLeft3()
        {

            bool esPerfecto = Week8.EsPerfecto(new int [4,4] {{2, 2, 2, 2} , {2, 2, 2, 2} , {2, 2, 2, 2}, {2, 2, 2,2}});

            Assert.AreEqual(esPerfecto, true);

        }

        [TestMethod]
        public void RotateLeft5()
        {

            int rotated = Week7.SearchBinary(new double[] { 2, 3, 4, 10, 25, 30, 31, 32, 40, 45, 50 }, 45);

            Assert.AreEqual(rotated, 9);

        }
    }
}
