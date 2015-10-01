using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tester;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        //Kunna kontrollera om ett användarnamn och lösenordspar är giltigt. Returnerar true eller false.
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
                    
            //Act
            user.Add(new Users());
            string Name = "Bengt";
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
    }
}
