using System;

namespace NumberEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc";
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]>=97 && str[i]<=122)
                {
                    result += Convert.ToInt32(str[i])-96;
                }
                else
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
