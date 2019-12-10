using NUnit.Framework;
using ToDoList.Helpers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestFixture]
    public class TestSettings: AuthBase
    {
        [Test]
        public void ChangeEmail()
        {
            App.Settings.ChangeEmail(User.Current, "test@test.test");
        }
    }
}