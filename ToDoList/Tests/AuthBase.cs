using NUnit.Framework;
using ToDoList.Helpers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    public class AuthBase : TestBase
    {
        private readonly User _user = new User { Username = Settings.UserName, Password = Settings.Password };

        [SetUp]
        public void SetupLogin()
        {
            if (LoginHelper.IsLoggedIn) return;
            App.Auth.Login(_user);
            LoginHelper.SetLoggedIn(true);
        }
    }
}