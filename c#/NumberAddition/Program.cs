using System;
using System.Text.RegularExpressions;

namespace NumberAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            //3Hello 9
            //
            string str = "T1wo Ho33uses";
            int total = 0;
            string[] strArr = Regex.Split(str,@"\D+");
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i]!="")
                {
                    total += int.Parse(strArr[i]);
                }
            }
            Console.WriteLine(total);
        }
    }
}
