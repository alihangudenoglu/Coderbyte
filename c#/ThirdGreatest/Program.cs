using System;
using System.Linq;

namespace ThirdGreatest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] { "abc", "defg", "z","hjkl"};
            strArr = strArr.OrderByDescending(x => x.Length).ToArray();
            Console.WriteLine(strArr[2]);

        }
    }
}
