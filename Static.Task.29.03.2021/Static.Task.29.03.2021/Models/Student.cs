using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Task._29._03._2021.Models
{
    class Student
    {
        private static int _id;

        public int ID { get; }
        public string FullName { get; set; }
        
        public int Point { get; set; }



        public Student(string fullName,  int point)
        {
            FullName = fullName;
            Point = point;
            _id++;
            ID = _id;
        }


        public override string ToString()
        {
            return StudentInfo();
        }

        public string StudentInfo()
        {

           return $"Student's ID: {ID} \n" +
                $"Student's FullName: {FullName} \n" +
                $"Student's Point: {Point} \n" +
                $"*****************************";
            
        }

    }
}
