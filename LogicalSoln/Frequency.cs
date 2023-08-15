using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//frequency of each digit in array
namespace LogicalSoln
{
    public class Frequency
    {
        static void Main(string[] args)
        {
            //from array
            //int[] arr = { 2, 3, 2, 3, 4, 5, 9, 8, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 1;
            //    bool isvisited = false;

            //    for (int k = i-1; k >=0; k--)//check the reverse direction
            //    {
            //        if(arr[k] == arr[i])
            //        {
            //            isvisited = true;
            //            break;
            //        }
            //    }
            //    if (isvisited == false)
            //    {
            //        for (int j = i + 1; j < arr.Length; j++)//check the forword direction
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine(arr[i] +" "+count);
            //    }
            //}
            //


            // from number to find frequency
            // int num = 1223447;
            Console.WriteLine("Enter a numbers=");
           int num= int.Parse(Console.ReadLine());
            int temp = num;

            for (int i = 0; i <=9; i++)
            {
                int count = 0;
                while(num>0)
                {
                    int digit=num%10;  
                    
                    if(digit==i)
                    {
                        count++;
                    }
                    num = num / 10;
                }

                num = temp;
                if(count!=0)
                {
                    Console.WriteLine(i+" frequency times "+count);
                }
            }
        }
    }
}
