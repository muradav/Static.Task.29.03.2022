using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Task._29._03._2021.Models
{
    class Group
    {
        private int _studentLimit;
        private string _groupNo;

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (!(CheckGroupNo(value)))
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine("GroupNo is not acceptable \n" +
                    "Please use two upper case in the begining and three digit");
                    return;
                }

                _groupNo = value;
            }
        }

        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (!(value >= 5) || !(value <= 18))
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine("Limit is out of range");
                    return;
                }
                _studentLimit = value;
            }
        }



        private Student[] students;

        public Group(string groupno, int studentlimit)
        {
            students = new Student[0];
            GroupNo = groupno;
            StudentLimit = studentlimit;

        }


        public bool CheckGroupNo(string groupNo)
        {
            //char[] arr = groupNo.ToCharArray();

            bool result = false;
            bool result1 = false;
            bool result2 = false;
            bool result3 = false;
            if (groupNo.Length == 5)
            {

                if (result1 != char.IsUpper(groupNo[0]))
                {
                    result1 = true;
                }

                if (result2 != char.IsUpper(groupNo[1]))
                {
                    result2 = true;
                }


                for (int i = 2; i < groupNo.Length; i++)
                {
                    if (result3 != char.IsDigit(groupNo[i]))
                    {
                        result3 = true;
                    }
                }
                result = result1 && result2 && result3;
            }

            return result;


        }

       

        public void AddStudent(Student stu)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = stu;
                Console.WriteLine($"Student has been added to group !");
                return;
            }


            Console.WriteLine($"Student limit is out of range");

        }



        public void GetStudent(int? id)
        {
            bool exist = false;
            foreach (Student stu in students)
            {
                if (id == stu.ID)
                {
                    Console.WriteLine(stu);
                    exist = true;
                    return;
                }
            }
            if (exist == false)
            {
                Console.WriteLine($"Student with this ID was not found in this group.");
            }
        }
        public void GetAllStudents()
        {
            foreach (Student stu in students)
            {
                Console.WriteLine(stu);
            }
        }
    }


    
}
