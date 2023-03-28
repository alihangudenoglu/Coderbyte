using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2,3,4,1,6,10 };
            int count = arr.Length;
            string result = "";
            for (int i = arr[0]; i < count; i++)
            {
                result += arr[i].ToString();
                if (i==arr.Length-1)
                {
                    i = -1;
                    count = arr[0];
                }
            }
            Console.WriteLine(result);





        }
    }
}
