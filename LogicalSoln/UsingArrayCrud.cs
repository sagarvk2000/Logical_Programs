using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSoln
{
    public class Book
    {
        int book_id;
        string book_name;
        int price;
        int count = 0;
        Book[] book = new Book[100];
        public Book()
            {
            }
        
        public Book(int book_id,string book_name,int price)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.price = price;
        }

        public void InsertBook()
        {
            Console.WriteLine("Enter hoe many books you want to insert =");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter book id=");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter book name =");
                string bname = Console.ReadLine();
                Console.WriteLine("Enter price");
                int price = int.Parse(Console.ReadLine());  

                book[count]=new Book(bid,bname,price);//count is used for to insert position or we can use book[i]
                count++;
            }
        }

        public void ShowBooks()
        {
            for (int i = 0; i < count; i++)
            {
                if(book[i]!=null)
                {
                    Console.WriteLine(book[i]);
                }
            }
        }
        //show book by book id by user
        public void SearchBook()
        {
            Book b = new Book();
            Console.WriteLine("Enter book id of ur wish");
            int sid = int.Parse(Console.ReadLine());
            bool isPresent = false;
            for (int i = 0; i < count; i++)
            {
                if (book[i] != null)
                {
                    if (book[i].book_id == sid)
                    {
                        isPresent = true;
                        b=book[i];
                    }
                }
            }
            if(isPresent)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("book is not present");
            }
        }

        public void UpdateBook()
        {
            Console.WriteLine("Enter id for update= ");
            int uid = int.Parse(Console.ReadLine());
            Console.WriteLine("Price =");
            int price = int.Parse(Console.ReadLine());
            bool isUpdate = false;

            for (int i = 0; i < count; i++)
            {
                if(book[i]!=null)
                {
                    if(book[i].book_id == uid)
                    {
                        book[i].price= price;
                        isUpdate = true;
                    }
                }
            }
            if(isUpdate)
            {
                Console.WriteLine("Update successfully......");
            }
        }

        public void DeleteBook()
        {
            Console.WriteLine("Enter id for delete =");
            int did = int.Parse(Console.ReadLine());
            bool isDelete = false;

            for (int i = 0; i < count; i++)
            {
                if(book[i]!=null)
                {
                    if(book[i].book_id==did)
                    {
                        //book[i]=null;
                        book[i]=book[i+1];
                        isDelete = true;
                      
                    }
                }
                count--;
                book[count] = null;
            }
            if (isDelete)
            {
                Console.WriteLine("Delete successfully......");
            }
            else
            {
                Console.WriteLine("Error.....!");
            }
        }
        public override string ToString()
        {
            return $"{book_id},{book_name},{price}";
        }
        

        static void Main(string[] args)
        {
            Book b = new Book();
            int opt1;
            do
            {


                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.insert");
                Console.WriteLine("2.Search");
                Console.WriteLine("3.Show");
                Console.WriteLine("4.update");
                Console.WriteLine("5.delete");


                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        b.InsertBook();
                        break;

                    case 2:

                        b.SearchBook();
                        break;

                    case 3:

                        b.ShowBooks();
                        break;

                    case 4:
                        b.UpdateBook();
                        break;

                    case 5:
                        b.DeleteBook();
                        break;


                }
                Console.WriteLine("Press 1 for continue=");
                 opt1 = int.Parse(Console.ReadLine());
            }
            while (opt1 == 1);
            
        }
    }
}
