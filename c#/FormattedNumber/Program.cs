using System;
using System.Globalization;

namespace FormattedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1.1.1.1";
            try
            {
                var strArr = str.Contains(".") ? str.Replace(",", "").Split('.') : str.Replace(",", "").Split();

                string total = decimal.Parse(strArr[0]).ToString("N0", CultureInfo.InvariantCulture);
                total = strArr.Length == 1 ? total : total + ("." + strArr[1]);
                if (total == str || "0" + total == str)
                {

                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("false");
            }


            //Console.WriteLine("The Number Formatting is as :" + dblValue.ToString("N0", CultureInfo.InvariantCulture)+ ("." + strArr[1]));

        }
    }
}
