using System;

namespace BitwiseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] {"101010101","000000011" };
            string result = "";
            for (int i = 0; i < strArr[0].Length; i++)
            {
                result += Convert.ToInt16(strArr[0][i]) * Convert.ToInt16(strArr[1][i]);
            }
            Console.WriteLine(result);
        }
    }
}
