using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace RomanNumeralReduction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "LXXXVVVIIIII";
            string[,] romanArr = new string[,] { { "I", "1" }, { "V", "5" }, { "X", "10" }, { "L", "50" }, { "C", "100" }, { "D", "500" }, { "M", "1000" } };
            
            int total = 0;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < romanArr.Length/2; j++)
                {
                    if (str[i].ToString()==romanArr[j,0])
                    {
                        total += int.Parse(romanArr[j, 1]);
                    }
                }
            }
            for (int i = (romanArr.Length / 2)-1; i>=0;)
            {
                if (total >= int.Parse(romanArr[i, 1]))
                {
                    total -= int.Parse(romanArr[i, 1]);
                    result += romanArr[i, 0];
                }
                else
                {
                    if (total == 0)
                    {
                        break;
                    }
                    i--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
