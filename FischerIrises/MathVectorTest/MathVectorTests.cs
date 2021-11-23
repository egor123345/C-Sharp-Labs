using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathVectorLib;

namespace MathVectorTest
{
    [TestClass]
    public class MathVectorTests
    {
        MathVector vector1;
        [TestInitialize]
        public void Initialize()
        {
            vector1 = new MathVector(2, 4, 1, -2);
        }

        [TestMethod]
        public void TestVectorDimensions4()
        {
            // arange
            int expected = 4;

            // act
            int received = vector1.dimensions;

            // assert
            Assert.AreEqual(expected, received);
        }

        [TestMethod]
        public void TestGetEnumerator()
        {
            // arange
            double [] expected = { 2, 4, 1, -2 };

            // act
            double[] recieved = new double[4];
            int coord_num = 0;
            foreach (var coord in vector1)
            {
                recieved[coord_num] = (Double)coord;
                coord_num++;
            }

            // assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], recieved[i]);
            }
        }

        [TestMethod]
        public void TestCloneVector()
        {
            // act
            MathVector vector2 = (MathVector)vector1.Clone();

            // assert
            for (int i = 0; i < vector1.dimensions; i++)
            {
                Assert.AreEqual(vector1[i], vector2[i]);
            }
            Assert.IsFalse(object.ReferenceEquals(vector2, vector1));

        }

        [TestMethod]
        public void TestCorrectElementIndexing()
        {
            //arange
            double expected = 5;
            // act
            vector1[2] = expected;
            double received = vector1[2];

            // assert
            Assert.AreEqual(expected, received);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestOutOfIndexMathVector()
        {
            // arrange
            int incorrect_index = 4444;

            //act
        
                double res = vector1[incorrect_index];

        }

        [TestMethod]
        public void TestVectorLength5()
        {
            //arrange
            double expected = 5;
            //act
            double received = vector1.length;

            //assert
            Assert.AreEqual(received, expected);
        }

        [TestMethod]
        public void TestSumVectorAndNumber5()
        {
            // arrange
            double num = 5;
            MathVector expected = new MathVector(7, 9, 6, 3);

            // act
            IMathVector received = vector1.sum_number(num);

            // assert         
            Assert.AreEqual(expected, received);
        }

       [TestMethod]
        public void TestMultVectorAndNumber2()
        {
            // arrange
            double num = 2;
            MathVector expected = new MathVector(4, 8, 2, -4);

            // act
            IMathVector received = vector1.multiply_number(num);

            // assert         
            Assert.AreEqual(expected, received);
        }


        [TestMethod]
        public void TestSum2Vectors()
        {
            // arrange
            MathVector vector2 = new MathVector(3, 2, 4, 1);
            MathVector expected = new MathVector(5, 6, 5, -1);

            // act
            IMathVector received = vector1.sum(vector2);
            // assert         
            Assert.AreEqual(expected, received);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSum2MultiDimensionalVectors()
        {
            // arrange

            MathVector vector2 = new MathVector(3, 2, 4, 1, 4);

            //act
            IMathVector received = vector1.sum(vector2);

        }

        [TestMethod]
        public void TestMult2Vectors()
        {
            // arrange
            MathVector vector2 = new MathVector(3, 2, 4, 1);
            MathVector expected = new MathVector(6, 8, 4, -2);

            // act
            IMathVector received = vector1.multiply(vector2);
            // assert         
            Assert.AreEqual(expected, received);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMultMultiDimensionalVectors()
        {
            // arrange

            MathVector vector2 = new MathVector(3, 2, 4, 1, 4);

            //act
            IMathVector received = vector1.multiply(vector2);

        }

        [TestMethod]
        public void TestScalarMult2Vectors()
        {
            // arrange
            MathVector vector2 = new MathVector(0, 2, 4, 1);
            double? expected = 10;

            // act
            double? received = vector1.scalar_multiply(vector2);

            //assert
            Assert.AreEqual(received, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestScalarMultMultiDimensionalVectors()
        {
            // arrange

            MathVector vector2 = new MathVector(3, 2, 4, 1, 4);

            //act
            double? received  = vector1.scalar_multiply(vector2);

        }

        [TestMethod]
        public void TestCalcEuclideanDistance2Vectors()
        {
            // arrange
            MathVector vector2 = new MathVector(0, 2, 3, -4);
            double? expected = 4;
            // act
            double? received = vector1.calc_distance(vector2);
            //assert
            Assert.AreEqual(received, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCalcEuclideanDistance2MultiDimensionalVectors()
        {
            // arrange

            MathVector vector2 = new MathVector(3, 2, 4, 1, 4);

            //act
            double? received = vector1.calc_distance(vector2);

        }
    }
}
            