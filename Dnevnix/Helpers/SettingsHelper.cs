using NUnit.Framework;
using OpenQA.Selenium;

namespace Dnevnix.Helpers
{
    public class SettingsHelper: HelperBase
    {
        public SettingsHelper(AppManager manager)
            : base(manager)
        {
        }

        public void ChangeName(string newName)
        {
            driver.Navigate().GoToUrl("https://dnevnix.ru/index.php/component/users/profile?layout=edit");
            driver.FindElement(By.Id("jform_name")).Click();
            driver.FindElement(By.Id("jform_name")).Clear();
            driver.FindElement(By.Id("jform_name")).SendKeys(newName);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='(необязательно)'])[2]/following::span[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сообщение'])[1]/following::p[1]")).Click();
            Assert.AreEqual("Профиль сохранен", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сообщение'])[1]/following::p[1]")).Text);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Имя'])[1]/following::dd[1]")).Click();
            Assert.AreEqual(newName, driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Имя'])[1]/following::dd[1]")).Text);
        }
    }
}