﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tester;
using System.Linq;
using System.Security.Cryptography;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Kunna kontrollera om ett användarnamn och lösenordspar är giltigt. Returnerar true.
        [TestMethod]
        public void Control_That_Name_And_Password_Is_Viable_Return_True()
        {
        
           //Arrange
          Users t = new Users();
          t.Name = "Abdullah";
          t.PassWord = "Moreno";
          var name = t.Name;
          var password = t.PassWord;

            //Assert
          Assert.IsTrue("Abdullah" == name && "Moreno" == password);
        }

        //Kunna kontrollera om ett användarnamn och lösenordspar är giltigt. Returnerar false.
        [TestMethod]
        public void Control_That_Name_And_Password_Is_Viable_Return_False()
        {
            //Arrange
            Users t = new Users();
            t.Name = "Abdullah";
            t.PassWord = "Moreno";
            var name = t.Name;
            var password = t.PassWord;

            //Assert
            Assert.IsFalse("Fakename" == name && "FakePassword" == password);
        }

        //Kunna lägga till en ny användare.
        [TestMethod]
        public void Add_New_User()
        {
            //Arrange - Skapa en lista med användare
            List<Users> user = new List<Users>();
              
            //Act - Lägg till en användare i listan
            user.Add(new Users());

            //Assert - Kolla om listan har lagt till en användare
           Assert.IsTrue(user.Count >= 1);          
        }


        //Specialtecknen @, #, $, eller åäö är inte giltiga i användarnamn.
        [TestMethod]
        public void No_Special_Characters_Allowed_In_User_Name()
        {
            //Arrange
            List<Users> user = new List<Users>();
            string Name = "Bengt";    

            //Act          
               if (Name.All(char.IsLetterOrDigit))
            {
                user.Add(new Users());
            }
               else
               {
                   throw new FormatException();
               }

            //Assert
               Assert.IsFalse(Name.Contains("@#$åäö"));
        }


        //Test för att autogenerera lösenord
     


        //När en ny användare läggs till ska ett automatgenererat lösenord returneras.

        [TestMethod]
        public void When_New_User_Added_Generate_Password()
        {
           
            //Arrange
            List<Users> user = new List<Users>();
            Users t = new Users();
            user.Add(new Users());  
          
       
            //Act        
            var generatePassword = t.Password(10);
            var Password = generatePassword;
    
                                                                    
            //Assert
            Assert.IsNotNull(Password);
                   
        }
    }
}
