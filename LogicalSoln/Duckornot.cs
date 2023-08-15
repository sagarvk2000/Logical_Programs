using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WPT check weather ien umber is duck(if input contains 0) number or not
namespace LogicalSoln
{
    public class Duckornot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int Dn;
            Dn = n;
            int count = 0;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    count++;
                    // break; //more than one zero then we will use break
                    //if we want only one zero we won't use break

                }
                n = n / 10;
            }
            if (count == 1)
            {
                Console.WriteLine("Duck no");
            }
            else
            {
                Console.WriteLine("Not a Duck");
            }
        }
    }
}
