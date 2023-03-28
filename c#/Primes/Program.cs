using System;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7001;
            Console.WriteLine(Prime(num));

        }
        static bool Prime(int num)
        {
            

            if (num % 2 == 0 && num != 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {

                        return false;
                    }
                }
                return true;
            }
        }
    }
}
