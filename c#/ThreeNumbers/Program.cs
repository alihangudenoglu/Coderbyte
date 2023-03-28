using System;

namespace ThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a2a3 bb34b6 cc7c16c";
            Console.WriteLine(Hesapla(str));
            
        }
        static bool Hesapla(string str)
        {
            int wordLength = str.Split(" ").Length;
            int count = 0;
            string nmrStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    count++;
                    nmrStr += str[i];
                }
                else
                {
                    count = 0;
                }
                if (count > 2)
                {
                    return false;
                }
            }
            if (nmrStr.Length % 3 == 0)
            {
                for (int i = 0; i < wordLength; i++)
                {
                    if (nmrStr[i*3] != nmrStr[i*3+1] && nmrStr[i*3] != nmrStr[i*3+2] && nmrStr[i*3+1] != nmrStr[i*3+2])
                    {
                        
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
