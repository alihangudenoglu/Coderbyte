using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ginger-brea d mAN";
            str = str.ToLower();
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 97 || str[i] > 122)
                {
                    result += " ";
                }
                else
                {
                    if (i!=0 && result[i-1]==' ')
                    {
                        result += str[i].ToString().ToUpper();
                        continue;
                    }
                    result += str[i];
                }
            }
            Console.WriteLine(result.Replace(" ",""));
        }
    }
}
