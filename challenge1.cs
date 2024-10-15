using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("register: enter username and password ");
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            Console.WriteLine("login: enter your username and password ");

            string login_username = Console.ReadLine();
            string login_password = Console.ReadLine();

            if (username == login_username && password == login_password)
            {
                Console.WriteLine("you have successfully logged in !!");
            } else
            {
                Console.WriteLine("wrong username or password!");
            } 

        }
    }
}
