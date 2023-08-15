using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Facinating number
//take 3 digit numnber from user multiply that number with respective 1 2 3 
//whatever the result concat it and check if concatinated string conatain 0-9 
//numbers only once if any digit repeat then display number is not facinating number
namespace LogicalSoln
{
    public class FancinatingNum
    {
        
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            
            string str = "";

            for (int m = 1; m <=3 ; m++)
            {
                str = str + (num * m);
            }

            Console.WriteLine(str);

            char[] ch = str.ToCharArray();
            int count = 1;
            bool IsFacinating=true;
            
            for (int i = 0; i < ch.Length; i++)
            {
                bool isVisited = false;
                
                for (int k = i - 1; k >= 0; k--)//backward direction
                {
                    if (ch[k] == ch[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                
                if (isVisited == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)//Forward direction
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }
                    }
                    if(count>1)
                    {
                        IsFacinating = false;
                        break;
                    }
                }
                
            }
            if(IsFacinating)
            {
                Console.WriteLine("Facinating");
            }
            else
            {
                Console.WriteLine("not Facinating");
            }
           
        }
    }
}
