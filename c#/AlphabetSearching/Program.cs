using System;
using System.Collections.Generic;

namespace AlphabetSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            //alpha = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]

            List<char> list = new List<char>();
            for (char c = 'a'; c <= 'z'; ++c)
            {
                list.Add(c);
            }
            string str = "123cdefg123hijklmn123opqrstuvyxwyzyz";
            for (int i = 0; i < str.Length; i++)
            {
                if (list.Contains(str[i]))
                {
                    list.Remove(str[i]);
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
