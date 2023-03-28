using System;

namespace SquareFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 11;
            int counter = 0;
            long result;
            while (true)
            {
                result = (long)Math.Pow(counter, 2);
                if (result.ToString().Length == len)
                {
                    Console.WriteLine(counter);
                    break;
                }
                counter++;
            }
        }
    }
}
