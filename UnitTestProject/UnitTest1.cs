using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tester;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        //Kunna kontrollera om ett användarnamn och lösenordspar är giltigt. Returnerar true eller false.
        [TestMethod]
        public void Control_That_Name_And_Password_Is_Viable_Return_True()
        {
            //Assert 
           //var user = new Tester.Users();
            //var name = user.Name;
            
          Users t = new Users();
          t.Name = "Abdullah";
          t.PassWord = "Moreno";
          var name = t.Name;
          var password = t.PassWord;
          Assert.IsTrue("Abdullah" == name && "Moreno" == password);
        }

        [TestMethod]
        public void Control_That_Name_And_Password_Is_Viable_Return_False()
        {
            Users t = new Users();
            t.Name = "Abdullah";
            t.PassWord = "Moreno";
            var name = t.Name;
            var password = t.PassWord;
            Assert.IsFalse("Fakename" == name && "FakeLastName" == password);
        }



        //Kunna lägga till en ny användare.
        [TestMethod]
        public void Add_New_User()
        {
            //Arrange - Skapa en lista med användare
            List<Users> user = new List<Users>();
       
            
            //Act - Lägg till en användare i listan
            user.Add(new Users() { Name = "Rofl", PassWord = "Copter" });

            //Assert - Kolla om listan har lagt till en användare
           Assert.IsTrue(user.Count >= 1);
          
        }
    }
}
