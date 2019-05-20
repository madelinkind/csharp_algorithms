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
            int[,] pascalTriangle = Week8.PascalTriangle2(4);

            Week8.PrintMatrix(pascalTriangle);

            CollectionAssert.AreEqual(pascalTriangle, new int[5, 5] {
                { 1, 0, 0, 0, 0 },
                { 1, 1, 0, 0, 0 },
                { 1, 2, 1, 0, 0 },
                { 1, 3, 3, 1, 0 },
                { 1, 4, 6, 4, 1 }
            });
        }
    }

    [TestClass]
    public class MirrorHorizontalTest
    {
        [TestMethod]
        public void WorksForColumnsLargerThanRows()
        {
            int[,] horizontal = Week8.Mirror(new int[4, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 20, 40, 12, 15, 12 }
                }, true);

            CollectionAssert.AreEqual(horizontal, new int[4, 5] {
                { 20, 40, 12, 15, 12},
                {  15, 25, 4, 3, 1 },
                { 5, 6, 7, 8, 12},
                { 1, 2, 3, 4, 2 }
            });
        }

        [TestMethod]
        public void WorksForrowsLargerThanColumns()
        {
            int[,] horizontal = Week8.Mirror(new int[6, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 24, 46, 17, 11, 3 },
                { 20, 40, 12, 15, 12 },
                { 2, 44, 62, 2, 92 }
                }, true);

            CollectionAssert.AreEqual(horizontal, new int[6, 5] {
                { 2, 44, 62, 2, 92},
                { 20, 40, 12, 15, 12},
                { 24, 46, 17, 11, 3},
                { 15, 25, 4, 3, 1},
                {  5, 6, 7, 8, 12 },
                { 1, 2, 3, 4, 2 }
            });
        }

        [TestMethod]
        public void WorksForColumnsLargerThanRowsWithEvenDimensions()
        {
            int[,] horizontal = Week8.Mirror(new int[4, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 20, 40, 12, 15, 12 }
                }, true);

            CollectionAssert.AreEqual(horizontal, new int[4, 5] {
                { 20, 40, 12, 15, 12},
                {  15, 25, 4, 3, 1 },
                { 5, 6, 7, 8, 12},
                { 1, 2, 3, 4, 2 }
            });
        }

        [TestMethod]
        public void WorksForRowsLargerThanColumnsWithOddDimensions()
        {
            int[,] horizontal = Week8.Mirror(new int[7, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 24, 46, 17, 11, 3 },
                { 20, 40, 12, 15, 12 },
                { 2, 44, 62, 2, 92 },
                { 2, 4, 2, 22, 91 }
                }, true);

            CollectionAssert.AreEqual(horizontal, new int[7, 5] {
                { 2, 4, 2, 22, 91},
                { 2, 44, 62, 2, 92},
                { 20, 40, 12, 15, 12 },
                { 24, 46, 17, 11, 3 },
                { 15, 25, 4, 3, 1},
                { 5, 6, 7, 8, 12 },
                { 1, 2, 3, 4, 2 }
            });
        }
    }

    [TestClass]
    public class MirrorTest2
    {
        [TestMethod]
        public void WorksForColumnsLargerThanRows()
        {
            int[,] vertical = Week8.Mirror2(new int[4, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 20, 40, 12, 15, 12 }
                }, false);

            CollectionAssert.AreEqual(vertical, new int[4, 5] {
                { 2, 4, 3, 2, 1 },
                { 12, 8, 7, 6, 5},
                { 1, 3, 4, 25, 15 },
                { 12, 15, 12, 40, 20 }
            });
        }

        [TestMethod]
        public void WorksForRowsLargerThanColumns()
        {
            int[,] horizontal = Week8.Mirror2(new int[6, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 24, 46, 17, 11, 3 },
                { 20, 40, 12, 15, 12 },
                { 2, 44, 62, 2, 92 }
                }, true);

            CollectionAssert.AreEqual(horizontal, new int[6, 5] {
                { 2, 44, 62, 2, 92},
                { 20, 40, 12, 15, 12},
                { 24, 46, 17, 11, 3},
                { 15, 25, 4, 3, 1},
                {  5, 6, 7, 8, 12 },
                { 1, 2, 3, 4, 2 }
            });
        }

        [TestMethod]
        public void WorksForColumnsLargerThanRowsWithEvenDimensions()
        {
            int[,] horizontal = Week8.Mirror2(new int[4, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 20, 40, 12, 15, 12 }
                }, true);

            CollectionAssert.AreEqual(horizontal, new int[4, 5] {
                { 20, 40, 12, 15, 12},
                {  15, 25, 4, 3, 1 },
                { 5, 6, 7, 8, 12},
                { 1, 2, 3, 4, 2 }
            });
        }

        [TestMethod]
        public void WorksForRowsLargerThanColumnsWithOddDimensions()
        {
            int[,] horizontal = Week8.Mirror2(new int[7, 5] {
                { 1, 2, 3, 4, 2 },
                { 5, 6, 7, 8, 12},
                { 15, 25, 4, 3, 1 },
                { 24, 46, 17, 11, 3 },
                { 20, 40, 12, 15, 12 },
                { 2, 44, 62, 2, 92 },
                { 2, 4, 2, 22, 91 }
                }, false);

            CollectionAssert.AreEqual(horizontal, new int[7, 5] {
                { 2, 4, 3, 2, 1 },
                { 12, 8, 7, 6, 5},
                { 1, 3, 4, 25, 15 },
                { 3, 11, 17, 46, 24 },
                { 12, 15, 12, 40, 20 },
                { 92, 2, 62, 44,  2 },
                { 91, 22, 2, 4, 2 }
            });
        }
    }

    [TestClass]
    public class FourOnLineTest
    {
        [TestMethod]
        public void WorksForResultTrue()
        {
            bool vertical = Week8.FourOnLine(new bool[6, 5] {
                { false, true, false, false, false },
                { false, false, true, true, true},
                { true, true, true, false, true},
                { false, false, true, true, true},
                { true, false, true, true, true},
                { true, false, true, true, true}
            });

            Assert.AreEqual(vertical, true);
        }

        [TestMethod]
        public void WorksForResultDiagonalTrue()
        {
            bool vertical = Week8.FourOnLine(new bool[6, 5] {
                { false, true, false, false, true },
                { false, false, true, false, true},
                { true, true, false, false, true},
                { false, false, true, true, false},
                { false, false, true, false, false},
                { true, false, true, true, true}
            });

            Assert.AreEqual(vertical, true);
        }

        [TestMethod]
        public void WorksForResultFalse()
        {
            bool vertical = Week8.FourOnLine(new bool[6, 5] {
                { false, true, false, false, true },
                { false, false, true, false, true},
                { true, true, false, false, true},
                { false, true, true, true, false},
                { false, false, true, false, false},
                { true, false, true, false, true}
            });

            Assert.AreEqual(vertical, false);
        }

    }
}

