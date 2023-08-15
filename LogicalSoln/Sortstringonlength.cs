using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSoln
{
    public class Sortstringonlength
    {
        static void Main(string[] args)
        {
            //sort the string by length
            /* string str = "India is the best Country";

             string[] str1 = str.Split();
             string temp = "";

             for (int i = 0; i < str1.Length; i++)
             {
                 for (int j = i + 1; j < str1.Length; j++)
                 {
                     if (str1[i].Length > str1[j].Length)
                     {
                         temp = str1[i];
                         str1[i] = str1[j];
                         str1[j] = temp;
                     }
                 }
             }
             foreach (string item in str1)
             {
                 Console.WriteLine(item);
             }
            */


            //sort array  
            /*int[] arr = { 6, 5, 3, 4, 2, 1 };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //if (arr[i] > arr[j])//decending
                    if (arr[i] > arr[j])//ascending order
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
            */


            //sort the string by same length i.e is,my
            //op--my is India Country  or  is my India Country
/*
            string str = "India is my Country";

            string[] str1 = str.Split();
            string temp = "";

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = i + 1; j < str1.Length; j++)
                {
                    if (str1[i].Length > str1[j].Length)
                    {
                        temp = str1[i];
                        str1[i] = str1[j];
                        str1[j] = temp;
                    }
                    else if(str1[i].Length == str1[j].Length)
                    {
                        int x = str1[i].CompareTo(str1[j]);
                        if(x<1)
                        {
                            string temp2 = str1[i];
                            str1[i] = str1[j];
                            str1[j] = temp2;
                        }
                    }
                }
            }
            foreach (string item in str1)
            {
                Console.WriteLine(item);
            }
            */

           
            
        }
    }
}
