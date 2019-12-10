using ToDoList.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestFixture]
    public class TestLogin: TestBase
    {
        
        [Test]
        public void LogInLogOut()
        {
            App.Auth.Login(User.Current);
            App.Auth.LogOut();
        }

        [Test]
        public void LogInWithWrongCredentials()
        {
            var wrongUser = new User {Username = Settings.UserName, Password = Settings.WrongPassword };
            Assert.Throws<NoSuchElementException>(() => { App.Auth.Login(wrongUser); });
        }
    }
}