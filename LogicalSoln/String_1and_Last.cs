using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to take one string from user which contain number 
//Calculate the 1st 3-digit sum and last 3-digit sum
//If both sums are same then display valid string otherwise throw one custom exception.
namespace LogicalSoln
{
    public class String_1and_Last
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sum = 0;
            bool flag = true;
            //while(str.Length>=3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] >= 'Z')
                    {
                        flag= false;
                        break;
                    }
                    else if (str[i] >= '0' && str[i] <= '9')
                    {
                        sum = sum + ((int)(char.GetNumericValue(str[i])));
                    }
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
