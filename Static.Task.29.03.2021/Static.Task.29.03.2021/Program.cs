using Static.Task._29._03._2021.Models;
using System;

namespace Static.Task._29._03._2021.Models
{
    class Program
    {

        enum UserMenu { Show_Info = 1, Create_New_Group, Show_All_Groups };
        enum StudentMenu { Show_All_Students = 1, Get_Student_by_ID, Add_Student, Quit };

        static void Main(string[] args)
        {

            Group[] group = new Group[0];

            User user = new User();
            Console.Write("Please enter the FullName: ");
            user.FullName = Console.ReadLine();

            Console.Write("Please enter the Email: ");
            user.Email = Console.ReadLine();

            Console.Write("Please enter the Password: ");
            user.Password = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("\n1) Show user info");
                Console.WriteLine("2) Create new group");
                int input = int.Parse(Console.ReadLine());
                

                switch (input)
                {
                    case (int)UserMenu.Show_Info:
                        Console.Clear();
                        user.ShowInfo();
                        break;

                    case (int)UserMenu.Create_New_Group:
                        Console.Clear();
                        Console.Write("\nPlease write the name of group: ");
                        string groupName = Console.ReadLine();
                        Console.Write($"Please enter the limit for the {groupName}: ");
                        int studentLimit = int.Parse(Console.ReadLine());
                        Group group1 = new Group(groupName, studentLimit);

                        if (group1.StudentLimit != 0 && group1.GroupNo != null)
                        {
                            Array.Resize(ref group, group.Length + 1);
                            group[group.Length - 1] = group1;
                            Console.WriteLine("*****************************");
                            Console.WriteLine($"{group1.GroupNo} created !");
                        }
                        if (group.Length > 0)
                        {
                            int input2;
                            do
                            {
                                Console.WriteLine("\n1) Show all students");
                                Console.WriteLine("\n2) Get student by id");
                                Console.WriteLine("\n3) Add student");
                                Console.WriteLine("\n0) Back to Main Menu");

                                input2 = int.Parse(Console.ReadLine());
                                switch (input2)
                                {
                                    case (int)StudentMenu.Show_All_Students:
                                        Console.Clear();                                        
                                        group1.GetAllStudents();                                        
                                        break;

                                    case (int)StudentMenu.Get_Student_by_ID:
                                        Console.Clear();                                        
                                        Console.Write("Please enter the student ID: ");
                                        int id = int.Parse(Console.ReadLine());
                                        group1.GetStudent(id);                                        
                                        break;

                                    case (int)StudentMenu.Add_Student:
                                        Console.Clear();                                        
                                        Console.Write("Enter student name: ");
                                        string fullName = Console.ReadLine();                                        
                                        Console.Write("Enter the point: ");
                                        int point = int.Parse(Console.ReadLine());

                                        Student student1 = new Student( fullName, point);
                                        group1.AddStudent(student1);                                        
                                        break;

                                    case (int)StudentMenu.Quit:
                                        break;

                                }
                            } while (input2 != 0);
                        }
                        break;
                } 

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
