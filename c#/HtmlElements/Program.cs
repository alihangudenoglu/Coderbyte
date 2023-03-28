using System;
using System.Collections.Generic;

namespace HtmlElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //<div><b><p>hello word</p></b></div>
            //<div><b><p>p</p></b></div>
            //<p>hello</p><div></div>
            //<em></em><em></em><p></b>
            //<b></p>
            //<p><p><em></em><p></p><i></p>
            //<i></i><i></i><i></i>abc<i></p>
            //hello word<p></p><div><em><b></b></em></p>
            string str = "<div><b><p>hello word</p></b></div>";
            List<string> open = new List<string>();
            List<string> close = new List<string>();
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i]=='<')
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[j]=='>')
                        {
                            if (str.Substring(i + 1, j - i - 1).StartsWith("/"))
                            {
                                close.Add(str.Substring(i + 1, j - i - 1));
                                break;
                            }
                            else
                            {
                                open.Add(str.Substring(i + 1, j - i - 1));
                                break;
                            }
                        }
                    }
                }
            }
            for (int j = open.Count - 1; j >= 0; j--)
            {                
                int counter = 0;
                for (int i = 0; i < close.Count; i++)
                {
                    if (close[i]==("/"+ open[j]))
                    {
                        close.RemoveAt(i);
                        counter++;
                        break;
                    }
                }
                if (counter==0)
                {
                    Console.WriteLine(open[j]);
                    goto LOAD;
                }
            }
            Console.WriteLine(true);
            LOAD: Console.WriteLine();
        }
    }
}
