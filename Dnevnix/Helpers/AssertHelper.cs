using NUnit.Framework;
using OpenQA.Selenium;

namespace Dnevnix.Helpers
{
    public class AssertHelper: HelperBase
    {
        public AssertHelper(AppManager manager)
            : base(manager)
        {
        }
        
        public void LoginTitle() 
            => Assert.AreEqual("Войти", driver.FindElement(By.ClassName("s-header-item__link s-header-item__link--login")).Text);
    }
}