using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create stu class stu has id name and 3 sub marks
//create 1st method to accept the stu details
//Calculate % of stu
//third methos to calculate grade as per the %
//create method to display all the details 

namespace LogicalSoln
{
    public class Student
    {
        int sid;
        string sname;
        int m1,m2, m3;
        double percent,total;

        public void StuDetails(int sid,string sname,int m1,int m2,int m3)
        {
            this.sid = sid;
            this.sname = sname;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public void CalPercent()
        {
            total = (m1 + m2 + m3);
            percent = (total/300)*100;
            CalGrade();
            Display();
            
        }

        public void CalGrade()
        {
            if(percent >= 40 && percent <=60)
            {
                Console.WriteLine("C Grade");
            }
            else if(percent >=60 && percent<=80)
            {
                Console.WriteLine("B Grade");
            }
            else if(percent>80)
            {
                Console.WriteLine("A Grade");
            }
            else
            {
                Console.WriteLine("Fail....");
            }
            
        }

        public void Display()
        {
            Console.WriteLine($"{sid},{sname},{m1},{m2},{m3},{percent}s");
        }

        static void Main(string[] args)
        {
            Student s = new Student();
            s.StuDetails (01,"sagar",65, 75, 80);
            s.CalPercent();
            
            
        }
    }
}
