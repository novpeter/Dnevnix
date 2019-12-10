using Dnevnix.Models;
using NUnit.Framework;

namespace Dnevnix.Tests
{
    [TestFixture]
    public class TestSettings: TestBase
    {
        [Test]
        public void ChangeName()
        {
            App.Auth.Login(User.current);
            App.Settings.ChangeName("Катерина");
        }
    }
}