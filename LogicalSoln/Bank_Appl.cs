using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSoln
{
    public class Dlhuerb
    {
        public enum Roles { Admin = 1, Customer = 2 }

        public enum AccountTypes { Saving = 1, Current = 2 }

        public class User
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public Roles Role { get; set; }
            public bool IsActive { get; set; }
        }
        public class Payee
        {
            public int PayeeId { get; set; }
            public int UserId { get; set; }
            public string Name { get; set; }
            public int AccNo { get; set; }
            public int Balance { get; set; }
            public int Amount { get; set; }
        }
        public class Account
        {
            public int UserId { get; set; }
            public int AccNo { get; set; }
            public double Balance { get; set; }
            public AccountTypes AccountType { get; set; }
        }
        public class UserCRUD
        {
            List<User> UserList = null;

            public static int count;
            public List<User> ShowAll()
            {
                return UserList;
            }
            public List<User> ShowCustomers()

            {

                List<User> list = new List<User>();

                foreach (User item in UserList)

                {

                    if (item.Role == Roles.Customer)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
            public List<User> ShowActiveUsers()
            {
                List<User> list = new List<User>();

                foreach (User item in UserList)
                {
                    if (item.IsActive == true)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
            public List<User> ShowDeactivedUsers()
            {
                List<User> list = new List<User>();

                foreach (User item in UserList)
                {
                    if (item.IsActive == false)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
            public UserCRUD()
            {
                count++;

                UserList = new List<User>();

                UserList.Add(new User { UserName = "admin", UserId = count, 
                    Password = "123", Role = Roles.Admin });
            }
            public void AddUser(User user)
            {
                user.Role = Roles.Customer;

                user.IsActive = true;

                count++;

                user.UserId = count;

                UserList.Add(user);
            }
            public void DeactivateUser(User user)
            {
                foreach (var item in UserList)
                {
                    if (item.UserId == user.UserId)
                    {
                        item.IsActive = false;
                        break;
                    }
                }
            }
            public void ActivateUser(User user)
            {
                foreach (var item in UserList)

                {

                    if (item.UserId == user.UserId)

                    {
                        item.IsActive = true;
                        break;
                    }
                }
            }
            public int ValidateUser(User user, out int userid)
            {

                userid = 0;

                foreach (User u in UserList)

                {

                    if (u.UserName == user.UserName && user.Password == u.Password && u.IsActive == true)

                    {
                        if (u.Role == Roles.Admin)
                        {
                            userid = u.UserId;
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 2;
            }
        }
        static void Main(string[] args)
        {
            int op = 6;
            int userid;
            UserCRUD userCRUD = new UserCRUD();

            do
            {
                Console.WriteLine("Login...");

                User user = new User();

                Console.WriteLine("Enter UserName");

                user.UserName = Console.ReadLine();

                Console.WriteLine("Enter Password");

                user.Password = Console.ReadLine();

                int result = userCRUD.ValidateUser(user, out userid);

                if (result == 1)
                {
                    Console.WriteLine("1. Add User");

                    Console.WriteLine("2. Modify User");

                    Console.WriteLine("3. Delete User");

                    Console.WriteLine("4. Activate User");

                    Console.WriteLine("5. Deactive User");

                    Console.WriteLine("6. Exit");

                    Console.WriteLine("Enter your option");

                    op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            User u = new User();

                            Console.WriteLine("Enter UserName");

                            u.UserName = Console.ReadLine();

                            u.Password = Console.ReadLine();

                            userCRUD.AddUser(u);
                            op = 6;
                            break;

                        case 6:
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                }
                else if (result == 0)
                {
                    Console.WriteLine("1. Check Balance");

                    Console.WriteLine("2. Add Payee");

                    Console.WriteLine("3. Rmove Payee");

                    Console.WriteLine("4. Transfer Amount");

                    Console.WriteLine("6. Exit");

                    Console.WriteLine("Enter your option");

                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            break;
                        case 6:
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                }
                else if (result == 2)
                {
                    op = 6;
                    Console.WriteLine("User name or password is wrong");
                }
            }
            while (op == 6);
        }
    }
}


