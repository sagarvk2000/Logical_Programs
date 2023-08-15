using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//find sum of factorial factors
namespace LogicalSoln
{
    public class FactorsSum
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int fact = 1,sum=0;

            for (int i = 1; i <=num; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
}
