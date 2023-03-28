using System;

namespace Wildcards
{
    class Program
    {
        static void Main(string[] args)
        {
            //++++** abcdehhhhhh
            //++*{5} gheeeee
            //+++++ abcdemmmmmm
            //$**+*{2} 7mmmrrrkbb
            //+$ af
            //*{1}*{1} rt
            //$$$$$ 65656vvr
            //* ttt
            //*{7} gggaggggg
            //+*{10}+ gphpppppppppp
            string str = "$****{4}+++$ 8fffbbbeeerrrrmkou";
            Console.WriteLine(Check(str));
        }
        static bool Check(string str)
        {
            string[] strArr = str.Split(" ");
            for (int i = 0; i < strArr[0].Length; i++)
            {
                if (strArr[0][i] == '+')
                {
                    if (strArr[1][0] >= 97 && strArr[1][0] <= 122)
                    {
                        strArr[1] = strArr[1].Remove(0, 1);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (strArr[0][i] == '$')
                {
                    if ((char)strArr[1][0] > 48 && (char)strArr[1][0] < 57)
                    {
                        strArr[1] = strArr[1].Remove(0, 1);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (strArr[0][i] == '*')
                {
                    if (i + 1 < strArr[0].Length)
                    {
                        if (strArr[0][i + 1] == '{')
                        {
                            char let = strArr[1][0];
                            for (int j = 0; j < int.Parse(strArr[0][i + 2].ToString()); j++)
                            {
                                if (strArr[1][0] == let)
                                {
                                    strArr[1] = strArr[1].Remove(0, 1);
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            char let = strArr[1][0];
                            for (int j = 0; j < 3; j++)
                            {
                                if (strArr[1][0] == let)
                                {
                                    strArr[1] = strArr[1].Remove(0, 1);
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        char let = strArr[1][0];
                        for (int j = 0; j < 3; j++)
                        {
                            if (strArr[1][0] == let)
                            {
                                strArr[1] = strArr[1].Remove(0, 1);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }

            }
            if (strArr[1].Length >= 1)
            {
                return false;
            }


            return true;
        }
    }
}
