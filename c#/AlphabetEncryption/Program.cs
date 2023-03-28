using System;

namespace AlphabetEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            //bcdefghijklmnopqrstN            
            //abSbaSaNbR
            string str = "bRcNdR";



            char[] strArr = str.ToCharArray();
            string result = "";

            for (int i = 0; i < strArr.Length; i++)
            {
                char temporary;
                if (i == 0)
                { 
                    if (strArr[i] != 'a')
                    {
                        temporary = (char)(strArr[i]-1);
                        result += temporary;
                    }
                    else
                    {
                        temporary = (char)(strArr[i]);
                        result += temporary;
                    }
                }
                else
                { 
                    if (strArr[i] == 'S')
                    {
                        if (strArr[i+3]!='S')
                        {
                            temporary = 'b';
                            result += temporary;
                        }
                        
                    }
                    if (strArr[i] == 'N')
                    {
                        temporary = (char)(strArr[i - 1]);
                        result += temporary;
                        result += temporary;
                    }
                    if (strArr[i] == 'L')
                    {
                        temporary = (char)((strArr[i - 1]) - 1);
                        result += temporary;
                    }
                    if (strArr[i] == 'R')
                    {
                        temporary = (char)((strArr[i - 1]) + 1);
                        result += temporary;
                    }
                }

            }
            Console.WriteLine(result);
        }
    }
}
