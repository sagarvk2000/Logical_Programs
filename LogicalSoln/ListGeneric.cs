using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//find the frequency of list 
namespace LogicalSoln
{
    public class ListGeneric
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> list = new List<string>();
            list.Add("red");
            list.Add("green");
            list.Add("red");
            list.Add("blue");
            list.Add("blue");
            /*
            for (int i = 0; i < list.Count; i++)
            {
                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)//check backword direction
                {
                    if (list[k] == list[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < list.Count; j++)//check forword direction
                    {
                        if (list[i] == list[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(list[i] + " " + count);
                }
               
            }
           */
            //using dictionary
            for (int i = 0; i < list.Count; i++)
            {
                int cnt = 1;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        cnt++;
                        list.RemoveAt(j);
                    }
                }
                dic.Add(list[i],cnt);
            }
            foreach (KeyValuePair<string, int> item in dic)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
               // Console.WriteLine(item.Value);
            }

            //or
            //for (int i = 0; i < list.Count; i++)
            //{
            //    int count = 1;
            //    for (int j = 0; j < list.Count; j++)
            //    {
            //        if (list[i] == list[j])
            //        {
            //            count++;
            //            list.RemoveAt(j);
            //        }
            //    }
            //    Console.WriteLine(list[i]+" "+count);
            //}



           




        }
    }
}
