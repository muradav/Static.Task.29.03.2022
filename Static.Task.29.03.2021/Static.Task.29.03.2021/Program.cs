using Static.Task._29._03._2021.Models;
using System;

namespace Static.Task._29._03._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                User user = new User();
                Console.Write("Please enter the FullName: ");
                user.FullName = Console.ReadLine();

                Console.Write("Please enter the Email: ");
                user.Email = Console.ReadLine();

                Console.Write("Please enter the Password: ");
                user.Password = Console.ReadLine();

                Console.WriteLine("*****************************");
                user.ShowInfo();

                Console.WriteLine("*****************************");
                Console.WriteLine("If you want continue press Enter, otherwise press ESC");

            } while (Console.ReadKey().Key!=ConsoleKey.Escape);
            


        }
    }
}
