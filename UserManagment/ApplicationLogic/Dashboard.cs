using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.DataBase.Models;
using UserManagment.DataBase.Repo;
using UserManagment.UI;

namespace UserManagment.ApplicationLogic
{
    public static partial class Dashboard
    {
        public static void AdminPanel(string email)
        {
            Console.WriteLine("/make-admin");
            Console.WriteLine("/add-user");
            Console.WriteLine("/update-user");
            Console.WriteLine("/remove-user");
            Console.WriteLine("reports");
            Console.WriteLine("/show-all-users");
            Console.WriteLine("/add-admin");
            Console.WriteLine("/update-admin");
            Console.WriteLine("/show-admins");
            Console.WriteLine("/remove-admin");
            Console.WriteLine("/log-out");



            while (true)
            {

                string command = Console.ReadLine();
                if (command == "/make-admin")
                {


                    Console.WriteLine("Enter email :");
                    string mail = Console.ReadLine();
                    mail = email;
                    User user = UserRepo.GetUserByEmail(email);
                    if (user == null)
                    {
                        Console.WriteLine("User not found");
                    }
                    else
                    {
                        UserRepo.Delete(user);
                        Admin admin = new Admin(user.FirstName, user.LastName, user.Email, user.Password);
                        UserRepo.AddUser(admin);
                        Console.WriteLine("Admin added to system");
                    }


                }
                else if (command == "/add-user")
                {
                    Authentication.Register();
                }
                else if (command == "/update-user")
                {

                    Console.Write("Enter user's email :");
                    string mail = Console.ReadLine();
                    User user = UserRepo.GetUserByEmail(mail);
                    if (user is Admin)
                    {
                        Console.WriteLine("User not found (admin)");
                    }
                    else if (user == null)
                    {
                        Console.WriteLine("User not found(null)");
                    }
                    else
                    {
                        User updateUser = new User(Authentication.GetFirstName(), Authentication.GetLastName());
                        UserRepo.UpdateUser(email, updateUser);
                        Console.WriteLine("Succesfully user updated");
                    }



                }
                else if (command == "/remove-user")
                {
                    Console.Write("Enter user's email :");
                    string mail = Console.ReadLine();
                    User user = UserRepo.GetUserByEmail(mail);
                    if (user is Admin)
                    {
                        Console.WriteLine("User not found(admin)");
                    }
                    else if (user == null)
                    {
                        Console.WriteLine("User not found(null)");
                    }
                    else
                    {
                        UserRepo.Delete(user);
                        Console.WriteLine("User succesfully deleted");
                    }
                }
                else if (command == "/show-all-users")
                {
                    foreach (User user in UserRepo.Users)
                    {
                        if (user is User)
                        {
                            Console.WriteLine(user.GetInfo());

                        }
                    }
                }
                else if (command == "/add-admin")
                {
                    Console.WriteLine("Add new admin:");
                    Admin newAdmin = new Admin(Authentication.GetFirstName(), Authentication.GetLastName(), Authentication.GetEmail(), Authentication.GetPassword());
                    UserRepo.AddUser(newAdmin);
                    Console.WriteLine("New admin added");
                }
                else if (command == "/update-admin")
                {
                    
                        Console.Write("Enter admin's email :");
                        string mail = Console.ReadLine();
                        User user = UserRepo.GetUserByEmail(mail);
                        if (user is User)
                        {
                            Console.WriteLine("Admin not found (user)");
                        }
                        else if (user == null)
                        {
                            Console.WriteLine("Admin not found(null)");
                        }
                        else
                        {
                            Admin updateAdmin = new Admin(Authentication.GetFirstName(), Authentication.GetLastName());
                            UserRepo.UpdateAdmin(email, updateAdmin);
                            Console.WriteLine("Admin Succesfully updated");
                        }

                    
                }
                else if (command == "/show-admins")
                {

                    foreach (User user in UserRepo.Users)
                    {
                        if (user is Admin)
                        {
                            Console.WriteLine(user.GetInfo());

                        }
                    }
                }
                else if (command == "/remove-admin")
                {
                    Console.Write("Enter admin's email :");
                    string mail = Console.ReadLine();
                    User admin = UserRepo.GetUserByEmail(mail);
                    if (admin is User)
                    {
                        Console.WriteLine("Admin not found(user)");
                    }
                    else if (admin == null)
                    {
                        Console.WriteLine("Admin not found(null)");
                    }
                    else
                    {
                        UserRepo.Delete(admin);
                        Console.WriteLine("Admin succesfully deleted");
                    }
                }
                else if (command == "/log-out")
                {
                    Program.Main(new string[] { });
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found");
                }
            }
        }
    }
    public static partial class Dashboard
    {
        public static void UserPanel(string email)
        {
            User user = UserRepo.GetUserByEmail(email);

            Console.WriteLine("/update-info");
            Console.WriteLine("/report-user");
            Console.WriteLine("/log-out");

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "/update-info")
                {
                    if (user.Email == email)
                    {
                        User updateUser = new User(Authentication.GetFirstName(), Authentication.GetLastName());
                        UserRepo.UpdateUser(email, updateUser);
                        Console.WriteLine("User succesfully updated");

                    }


                }
                else if (command == "/report-user")
                {

                }
                else if (command == "/log-out")
                {
                    Program.Main(new string[] { });
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found");
                }
            }
        }
    }
}
