using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSoln
{
    public class Practice
    {

        public static bool CheckPrime(int n)
        {
            //prime array
            for (int i = 2; i < n; i++)
            {
                if(n%i==0)
                {
                    return false; 
                    break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //Duplicate array
           /* int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!list.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
           */

            //prime in array
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(CheckPrime(arr[i]))
                {
                    Console.WriteLine(arr[i]);
                }
            
            }
        }
    }
}
