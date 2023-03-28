using System;

namespace StarRating
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "4.63";
            str = str.Replace(".", ",");
            string result = "";
            double number = (Math.Round((Convert.ToDouble(str) * 2)) / 2);
            for (int i = 1; i < 6; i++)
            {
                if (number >= i)
                {
                    result += "full ";
                }
                else if (number<i && number>i-1)
                {
                    result += "half ";
                }
                else
                {
                    result += "empty ";
                }
            }
            Console.WriteLine(result);


        }
    }
}
