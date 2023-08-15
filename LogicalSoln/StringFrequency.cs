using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//check frquency of each word
//check frequency of each character
namespace LogicalSoln
{
    public class StringFrequency
    {

        static void FreqChar(string s)
        {
            char[] ch = s.ToCharArray();
            int i, j, k;
            for (i = 0; i < ch.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }
                    }
                    if (ch[i] != ' ')
                    {

                        Console.WriteLine(ch[i] + " " + count);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            

            //Character Frequency  
            /*
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            int i, j, k;
            for (i = 0; i < ch.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }
                    }
                    if (ch[i] != ' ')
                    {

                        Console.WriteLine(ch[i] + " " + count);
                    }
                }
            }
            */

           /*
            //Word frequency 
            string s = "pankaj is is smart";

            string[] s2 = s.Split(" ");

            for (int i = 0; i < s2.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (s2[k] == s2[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < s2.Length; j++)
                    {
                        if (s2[j] == s2[i])
                        {
                            count++;
                        }
                    }
                    if (s2[i] != " ")
                    {

                        Console.WriteLine(s2[i] + " " + count);
                    }
                }
            }
           */
        }

    }
}
