using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Task._29._03._2021.Models
{
    class User:IAccount
    {
        private static int _id;
        public  int ID { get;}


        public string FullName { get; set; }
        public string Email { get; set; }

        private string _password;
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                if (!(value.Length >= 8) || PasswordChecker(value) == false)
                {

                    Console.WriteLine("*****************************");
                    Console.WriteLine("Password invalid \n" +
                    "Please use at least one upper case, low case and one digit");
                    

                    return;
                }

                
                _password = value;
                Console.WriteLine("*****************************");
                Console.WriteLine("Password is created!");
                
                
            } 
        }


        public User(string email, string password)
        {
            Email = email;
            Password = password;
            
        }
        public User()
        {
            _id++;
            ID = _id;   
            
        }

        public bool PasswordChecker(string password)
        {
            char[] arr = password.ToCharArray();

            bool result = false;
            bool result1 = false;
            bool result2 = false;
            bool result3 = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (result1 != char.IsUpper(arr[i]))
                {
                    result1 = true;
                }

                if (result2 != char.IsLower(arr[i]))
                {
                    result2 = true;
                }

                if (result3 != char.IsDigit(arr[i]))
                {
                    result3 = true;
                }
                if (result1 == true && result2 == true && result3 == true)
                {
                    result = true;

                }




            }

            return result;
        }

        public void ShowInfo()
        {
            if (Password!=null)
            {
                Console.WriteLine($"User ID: {ID} \n" +
                $"FullName: {FullName} \n" +
                $"Email: {Email}");
            }
        }
    }

    interface IAccount
    {
        public bool PasswordChecker(string password);
       
        public void ShowInfo();
    }

}
