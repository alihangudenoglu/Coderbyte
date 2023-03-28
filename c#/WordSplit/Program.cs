using System;

namespace WordSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] {"abbbbcd","a,ab,b,bbbcd,c,d,dog,elf,f,farm,go,goal,hello"};
            string[] arr = strArr[1].Split(",");
            string result = "not possible";
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == strArr[0])
                    {
                        result = arr[i] + "," + arr[j];
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
