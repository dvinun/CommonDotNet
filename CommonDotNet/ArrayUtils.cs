using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dvinun.CommonDotNet.Utils
{
    public class Array
    {
        public static List<List<int>> Get2DArrayFromString(string arrayInput, int m, int n)
        {
            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                matrix.Add(arrayInput.Split(' ').ToList().
                    Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            return matrix;
        }
    }
}
