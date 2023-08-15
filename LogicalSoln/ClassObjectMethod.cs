using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create acc class acc has acc no, acctype, balance, write methods to accept details for acc no, type, and balnce
//create method to display acc info create method withdrawal,create deposite method to increase the current blance
//create method of check balance
namespace LogicalSoln
{
    public class Account
    {
        int accno;
        string acctype;
        double balance;


        public void AcceptD(int accno,string acctype,double balance)
        {
            this.accno = accno;
            this.acctype = acctype;
            this.balance = balance;
        }

        public void Credit(int amt)
        {
            balance = balance+amt;
        }

        public void Debit(int d)
        {
            balance -= d;
        }

        public void Balance()
        {
            this.balance=balance;
        }



        public string Display()
        {
            return $"{accno},{acctype},{balance}";
        }

        static void Main(string[] args)
        {
            Account account = new Account();
            account.AcceptD(111, "saving", 5000);
            account.Credit(2000);
            //account.Debit(1000);
            Console.WriteLine(account.Display());
        }
    }
}
