using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixTestProject
{
    [TestClass]
    public class UnitTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 9, 8, 9 }, 2)] // 3 x 3
        [DataRow(new int[] { 5, 3, 1, 8, 2, 4, -3, 8, 2 }, 9)] // 3 x 3 with negative number
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2 }, 8)] // 4 x 4
        [DataRow(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 2, 3, 4, 5, 4, 3, 2, 1, 2, 3, 4, 5, 4, 3, 2, 1 }, 4)] // 5 x 5
        public void TestMatrixResult(int[] matrixArray, int expectedResult)
        {
            List<int> matrixValueList = matrixArray.ToList();

            int calculatedValue = Matrix.Bll.Calculations.CalculateMatrix(matrixValueList);

            Assert.AreEqual(expectedResult, calculatedValue);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid matrix size!")]
        [DataRow(new int[] { 1 })] // 1 item | invalid
        [DataRow(new int[] { 1, 2 })] // 2 items | invalid
        [DataRow(new int[] { 1, 2, 3 })] // 3 items | invalid
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 9, 8, 9, 10 })] // 10 items | invalid
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 9, 8, 9, 10, 11 })] // 11 items | invalid
        public void TestInvalidData(int[] matrixArray)
        {
            List<int> matrixValueList = matrixArray.ToList();

            int calculatedValue = Matrix.Bll.Calculations.CalculateMatrix(matrixValueList);           
        }
    }
}