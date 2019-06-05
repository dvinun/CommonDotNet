using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Dvinun.CommonDotNet.Utils
{
    public class Math
    {
        // Get all combinations of an input
        public static IEnumerable<string> GenerateAllCombinations(string input)
        {
            var output = new List<string>();
            output.AddRange(getCombination(input[0], input.Substring(1,input.Length-1)));
            return output;
        }

        static List<string> getCombination(char charInput, string stringInput)
        {
            if (charInput == '\0' || string.IsNullOrEmpty(stringInput)) return new List<string>() { charInput.ToString() };

            var output = new List<string>();

            List<string> combs = getCombination(stringInput[0], stringInput.Substring(1, stringInput.Length - 1));

            combs.ForEach(comb => {

                // 1 + ABC => 1ABC
                output.Add(charInput + comb);
                
                // 1 + ABC => A1BC, AB1C 
                for (int i = 0; i < comb.Length - 1; i++)
                    output.Add(comb.Substring(0,i+1) + charInput.ToString() + comb.Substring(i + 1,comb.Length-(i+1)));
                
                // 1 + ABC => ABC1
                output.Add(comb + charInput);
            });

            return output;
        }
    }
}
