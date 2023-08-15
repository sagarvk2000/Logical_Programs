using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//find krishnmurthy no
namespace LogicalSoln
{
    public class Krishnmurthy_no
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while (num > 0)
            {
                int digit= num % 10;
                int fact = 1;

                for (int i = 1; i <=digit ; i++)
                {
                    fact = fact * i;
                }
                sum=sum + fact;
                num = num / 10;
            }
            if(sum==temp)
            {
                Console.WriteLine("its krishnmurthy no "+sum);
            }
            else
            {
                Console.WriteLine("its not krishnmurthy no "+sum);
            }
        }
    }
}
