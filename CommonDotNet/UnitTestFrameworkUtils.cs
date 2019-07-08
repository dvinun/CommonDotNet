using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dvinun.CommonDotNet.Utils
{
    public class UnitTest
    {
        public static void CompareArrays<T>(T[] expected, T[] actual)
        {
            Assert.AreEqual(expected == null, actual == null, "Expected {0}null value and {1}null found.", expected == null ? "" : "not", actual == null ? "" : "not");
            if (expected == null || actual == null)
                return;

            Assert.AreEqual(expected.LongLength, actual.LongLength, "Expected Length is {0} actual: {1}", expected.LongLength, actual.LongLength);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "Values on index {0} are not equal. Expected {1} actual: {2}", i, expected[i], actual[i]);
            }
        }

        public static void Compare2DArrays<T>(T[,] array1, T[,] array2)
        {
            foreach (T array1Item in array1)
            {
                foreach (T array2Item in array2)
                {
                }
            }


            //Assert.AreEqual(expected == null, actual == null, "Expected {0}null value and {1}null found.", expected == null ? "" : "not", actual == null ? "" : "not");
            //if (expected == null || actual == null)
            //    return;

            //Assert.AreEqual(expected.LongLength, actual.LongLength, "Expected Length is {0} actual: {1}", expected.LongLength, actual.LongLength);

            //for (int i = 0; i < expected.Length; i++)
            //{
            //    Assert.AreEqual(expected[i], actual[i], "Values on index {0} are not equal. Expected {1} actual: {2}", i, expected[i], actual[i]);
            //}
        }
    }
}
