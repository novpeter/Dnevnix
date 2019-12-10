using Dnevnix.Helpers;
using Dnevnix.Models;
using NUnit.Framework;

namespace Dnevnix.Tests
{
    [TestFixture]
    public class TestLogin: TestBase
    {
        
        [Test]
        public void LogInLogOut()
        {
            App.Auth.Login(User.current);
            App.Auth.LogOut();
        }
        
    }
}