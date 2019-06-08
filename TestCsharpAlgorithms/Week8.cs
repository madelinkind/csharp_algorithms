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

    [TestClass]
    public class SopaTest
    {
        [TestMethod]
        public void WorksForResultHorizontalTrue()
        {
            Ubicacion horizontal = Week8.FindWord(new char[6, 5] {
                { 'A', 'G', 'K', 'O', 'P' },
                { 'P', 'E', 'P', 'I', 'P'},
                { 'F', 'P', 'E', 'U', 'P'},
                { 'O', 'U', 'E', 'O', 'E'},
                { 'Y', 'Y', 'R', 'P', 'Y'},
                { 'P', 'E', 'P', 'E', 'U'}
            }, "PEPE");

            Assert.AreEqual(horizontal.FilaInicio, 5);
            Assert.AreEqual(horizontal.FilaFinal, 5);
            Assert.AreEqual(horizontal.ColumnaInicio, 0);
            Assert.AreEqual(horizontal.ColumnaFinal, 3);
        }

        [TestMethod]
        public void WorksForResultDiagonalTrue()
        {
            Ubicacion encontardo = Week8.FindWord(new char[6, 6] {
            { 'r', 't', 't', 'u','r','r' },
            { 'r', 'i', 'e', 'i','r','r' },
            { 'r', 'r', 'y', 'p','c','r' },
            { 'r', 'r', 'y', 'u','e','r' },
            { 'r', 'r', 'y', 'u','r','r' },
            { 'r', 'r', 'y', 'u','r','r' }
            }, "tic");

            Assert.AreEqual(encontardo.FilaInicio, 0);
            Assert.AreEqual(encontardo.FilaFinal, 2);
            Assert.AreEqual(encontardo.ColumnaInicio, 2);
            Assert.AreEqual(encontardo.ColumnaFinal, 4);
        }

        [TestMethod]
        public void WorksForResulsVerticalTrue()
        {
            Ubicacion vertical = Week8.FindWord(new char[6, 5] {
                { 'A', 'G', 'K', 'O', 'P' },
                { 'P', 'E', 'P', 'I', 'P'},
                { 'F', 'P', 'E', 'U', 'P'},
                { 'O', 'U', 'P', 'O', 'E'},
                { 'Y', 'Y', 'E', 'P', 'Y'},
                { 'P', 'E', 'P', 'O', 'E'}
            }, "PEPE");

            Assert.AreEqual(vertical.FilaInicio, 1);
            Assert.AreEqual(vertical.FilaFinal, 4);
            Assert.AreEqual(vertical.ColumnaInicio, 2);
            Assert.AreEqual(vertical.ColumnaFinal, 2);
        }
    }

    [TestClass]
    public class MultiplyTest
    {
        [TestMethod]
        public void WorksFor()
        {
            int[,] horizontal = Matrix.Multiply(new int[4, 3] {
                { 1, 2, 3},
                { 5, 6, 7},
                { 1, 5, 4 },
                { 2, 4, 2}
                },
                new int[3, 3] {
                { 1, 2, 3},
                { 1, 2, 1},
                { 4, 5, 4},
                });

            CollectionAssert.AreEqual(horizontal, new int[4, 3] {
                { 15, 21, 17},
                { 39, 57, 49},
                { 22, 32, 24},
                { 14, 22, 18}
            });
        }

        [TestMethod]
        public void WorksForMoreCols()
        {
            int[,] horizontal = Matrix.Multiply(new int[4, 3] {
                { 1, 2, 3},
                { 5, 6, 7},
                { 1, 5, 4},
                { 2, 4, 2}
                },
                new int[3, 2] {
                { 1, 2},
                { 1, 2},
                { 4, 5},
                });

            CollectionAssert.AreEqual(horizontal, new int[4, 2] {
                { 15, 21},
                { 39, 57},
                { 22, 32},
                { 14, 22}
            });
        }

        [TestMethod]
        public void WorksForMoreRows()
        {
            int[,] horizontal = Matrix.Multiply(new int[4, 3] {
                { 1, 2, 3},
                { 5, 6, 7},
                { 1, 5, 4},
                { 2, 4, 2}
                },
                new int[3, 4] {
                { 1, 2, 3, 3},
                { 1, 2, 3, 2},
                { 4, 5, 2, 1},
                });

            CollectionAssert.AreEqual(horizontal, new int[4, 4] {
                { 15, 21, 15, 10 },
                { 39, 57, 47, 34},
                { 22, 32, 26, 17},
                { 14, 22, 22, 16}
            });
        }
    }

    [TestClass]
    public class TestMatrixMultiplyOperatorOverride
    {
        [TestMethod]
        public void WorksFor()
        {
            Matrix m1 = new Matrix(new double[4, 3] {
                { 1, 2, 3},
                { 5, 6, 7},
                { 1, 5, 4},
                { 2, 4, 2}}
            );

            Matrix m2 = new Matrix(new double[3, 3] {
                { 1, 2, 3},
                { 1, 2, 1},
                { 4, 5, 4},
                });

            Matrix product = m1 * m2;

            CollectionAssert.AreEqual(product.data, new double[4, 3] {
                { 15, 21, 17},
                { 39, 57, 49},
                { 22, 32, 24},
                { 14, 22, 18}
            });
        }

        [TestMethod]
        public void WorksForMoreCols()
        {
            int[,] horizontal = Matrix.Multiply(new int[4, 3] {
                { 1, 2, 3},
                { 5, 6, 7},
                { 1, 5, 4},
                { 2, 4, 2}
                },
                new int[3, 2] {
                { 1, 2},
                { 1, 2},
                { 4, 5},
                });

            CollectionAssert.AreEqual(horizontal, new int[4, 2] {
                { 15, 21},
                { 39, 57},
                { 22, 32},
                { 14, 22}
            });
        }
        [TestMethod]
        public void WorksForMoreRows()
        {
            int[,] horizontal = Matrix.Multiply(new int[4, 3] {
                { 1, 2, 3},
                { 5, 6, 7},
                { 1, 5, 4},
                { 2, 4, 2}
                },
                new int[3, 4] {
                { 1, 2, 3, 3},
                { 1, 2, 3, 2},
                { 4, 5, 2, 1},
                });

            CollectionAssert.AreEqual(horizontal, new int[4, 4] {
                { 15, 21, 15, 10 },
                { 39, 57, 47, 34},
                { 22, 32, 26, 17},
                { 14, 22, 22, 16}
            });
        }
    }

    [TestClass]
    public class TestMatrixSumOperatorOverride
    {
        [TestMethod]
        public void WorksFor()
        {
            Matrix m1 = new Matrix(new double[4, 5] {
                { 1, 2, 3, 4, 4},
                { 1, 2, 1, 4, 4},
                { 4, 5, 4, 5, 6},
                { 2, 4, 2, 5, 7}
                });

            Matrix m2 = new Matrix(new double[4, 5] {
                { 1, 2, 3, 4, 4},
                { 1, 2, 1, 4, 4},
                { 4, 5, 4, 5, 6},
                { 2, 4, 2, 5, 7}
                });

            Matrix product = m1 + m2;

            CollectionAssert.AreEqual(product.data, new double[4, 5] {
                { 2, 4, 6, 8, 8},
                { 2, 4, 2, 8, 8},
                { 8, 10, 8, 10, 12},
                { 4, 8, 4, 10, 14}
                });
        }
    }

    [TestClass]
    public class TestMatrixSubstractionOperatorOverride
    {
        [TestMethod]
        public void WorksFor()
        {
            Matrix m1 = new Matrix(new double[4, 5] {
                { 1, 2, 3, 4, 4},
                { 1, 2, 1, 4, 4},
                { 4, 5, 4, 5, 6},
                { 2, 4, 2, 5, 7}
                });

            Matrix m2 = new Matrix(new double[4, 5] {
                { 1, 2, 3, 4, 4},
                { 1, 2, 1, 4, 4},
                { 4, 5, 4, 5, 6},
                { 2, 4, 2, 5, 7}
                });

            Matrix product = m1 - m2;

            CollectionAssert.AreEqual(product.data, new double[4, 5] {
                { 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0}
                });
        }
    }

    [TestClass]
    public class TestMatrixScalarOperatorOverride
    {
        [TestMethod]
        public void WorksFor()
        {
            Matrix m = new Matrix(new double[4, 5] {
                { 1, 2, 3, 4, 4},
                { 1, 2, 1, 4, 4},
                { 4, 5, 4, 5, 6},
                { 2, 4, 2, 5, 7}
                });
            Matrix product = m * 2;

            CollectionAssert.AreEqual(product.data, new double[4, 5] {
                { 2, 4, 6, 8, 8},
                { 2, 4, 2, 8, 8},
                { 8, 10, 8, 10, 12},
                { 4, 8, 4, 10, 14}
                });
        }
    }

    [TestClass]
    public class TestConjuntoEnterosIntersection
    {
        [TestMethod]
        public void WorksForIntersection()
        {
            
            ConjuntoEnteros m1 = new ConjuntoEnteros(new List<int> {2, 3, 9, 7, 6});
            ConjuntoEnteros m2 = new ConjuntoEnteros(new List<int> {2, 3, 7});

            ConjuntoEnteros product = m1 / m2;

            CollectionAssert.AreEqual(product.ListA, new List<int> {2, 3, 7});
        }
    }

    [TestClass]
    public class TestConjuntoEnterosUnion
    {
        [TestMethod]
        public void WorksForUnion()
        {
            
            ConjuntoEnteros m1 = new ConjuntoEnteros(new List<int> {9, 2, 2, 3, 1, 4, 5, 7, 9, 10, 12});
            ConjuntoEnteros m2 = new ConjuntoEnteros(new List<int> {8, 1, 6, 2, 3, 2});

            ConjuntoEnteros product = m1 + m2;

            CollectionAssert.AreEqual(product.ListA, new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12});
        }
    }
}

