using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSoln
{
    public class Shopping
    {
        int pid, price, qty, bill;
        string pname;

        public void AcceptDetails(int pid,string pname,int price,int qty)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
            this.qty = qty;
        }

        public void CalculateBill()
        {
           if(qty > 0)
            {
                bill = qty * price;
                ShowDetails();
            }
            else
            {
                //throw new Exception
               Console.WriteLine("qty must be atleast 1");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{pid},{pname},{price},{bill}");
        }
        //public string ShowDetails()
        //{
        //    return $"{pid},{pname},{price},{bill}"; //if we return the this we have to accept it on main method by object as below 
        //}

        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.AcceptDetails(1,"pen",200,0);
            s.CalculateBill();
            //Console.WriteLine(s.ShowDetails());
        }
    }

}
