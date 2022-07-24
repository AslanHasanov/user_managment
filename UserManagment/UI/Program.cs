using System;
using UserManagment.ApplicationLogic;

namespace UserManagment.UI
{
    internal  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Commands :");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter command : ");
                string command = Console.ReadLine();

                if (command == "/register")
                {
                    Authentication.Register();
                }
                else if (command == "/login")
                {
                    Authentication.Login();
                }

                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found!");
                }
            }
        }
    }
}
