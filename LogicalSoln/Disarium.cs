using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSoln
{
    public class Disarium
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int temp = num;

            while (num > 0)
            {               
                count++;
                num = num / 10;
            }
            num = temp;
            int sum = 0;

            while (num>0)
            {
                int digit = num % 10;
                int power = 1;
                
                for (int i = 1; i <=count ; i++)
                {
                    power = power * digit;
                }
                 sum += power;
                count--;
                num= num / 10;
            }
            num =temp ;
            if(sum==num)
            {
                Console.WriteLine("Disarium");
            }
            else
            {
                Console.WriteLine("Not disarium");
            }
        }
    }
}
