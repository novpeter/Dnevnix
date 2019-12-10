using NUnit.Framework;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestFixture]
    public class TestSettings: TestBase
    {
        [Test]
        public void ChangeEmail()
        {
            App.Auth.Login(User.Current);
            App.Settings.ChangeEmail(User.Current, "test@test.test");
            App.Auth.LogOut();
        }
    }
}