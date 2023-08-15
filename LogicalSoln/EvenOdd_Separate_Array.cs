using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to create int array and separate out the even element and odd element in two different array
namespace LogicalSoln
{
    public class EvenOdd_Separate_Array
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,2,3,4,5,6,7};

            int[] arr2 = new int[arr1.Length];//even

            int[] arr3 = new int[arr1.Length];//odd

            int m=0,k=0;//deals with index

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[m] = arr1[i];
                    m++;
                }
                else 
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine("Even array-----------");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("Odd array------------");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
