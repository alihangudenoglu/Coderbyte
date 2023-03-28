using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            int min = num1 < num2 ? num1 : num2;
            int result=1;
            for (int i = 1; i <= min; i++)
            {
                if (num1%i==0 && num2%i==0)
                {
                    result = i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
