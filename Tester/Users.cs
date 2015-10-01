﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
   public class Users
    {
        public string Name { get; set; }
        public string PassWord { get; set; }


       public void Add_User()
        {
            List<Users> user = new List<Users>();
            //user.Add(new Users() { Name = "Rofl", PassWord = "Copter" });
            if (Name.All(char.IsLetterOrDigit))
            {
                user.Add(new Users());
            }
            else
            {
                throw new FormatException();
            }
        }


       public string Password(int length)
       {
           char[] charArr = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
           string randomString = string.Empty;
           Random objRandom = new Random();
           for (int i = 0; i < length; i++)
           {
               //Don't Allow Repetation of Characters
               int x = objRandom.Next(1, charArr.Length);
               if (!randomString.Contains(charArr.GetValue(x).ToString()))
                   randomString += charArr.GetValue(x);
               else
                   i--;
           }
           return randomString;
       }


        #region Gammalt skit
        //Första test
       //public string Name = "Abdullah";
       //public string PassWord = "Moreno";

       //public List<Users> user = new List<Users>();

       //public void Add(Users users)
       //{
       //    user.Add(new Users() { Name = "Rofl", PassWord = "Copter" });
       //}

        //List<Users> _users = new List<Users>();

        //public Users()
        //{
        //    Users user = new Users();        

        //    user.Name = "Abdullah";
        //    user.PassWord = "Moreno";

        //    _users.Add(user);
        //}
        #endregion

    }

    
}
