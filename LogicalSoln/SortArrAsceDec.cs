using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSoln
{
    public class SortArrAsceDec
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 88, 6, 5, 9, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length/2; j++)
                {
                    if(arr[i]<arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = arr.Length+1; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])

                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
