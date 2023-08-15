using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sum of Even
//Sum of Odd
namespace LogicalSoln
{
    public class SumEvenOddArray
    {
        
        public static void SumEven(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(i%2==0)
                {                   
                     sum = sum + a[i];
                }
            }
            Console.WriteLine(sum );

            Console.WriteLine("==================================================");
        }
        public static void SumOdd(int[] s)
        {
            int sum1 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(i%2!=0)
                {
                    sum1 = sum1 +s[i];
                }
            }
            Console.WriteLine(sum1);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, };

            SumEvenOddArray.SumEven(arr);

            SumEvenOddArray.SumOdd(arr);

        }
    }
}
