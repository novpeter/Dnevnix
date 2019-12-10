using ToDoList.Helpers;
using NUnit.Framework;
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
        
    }
}