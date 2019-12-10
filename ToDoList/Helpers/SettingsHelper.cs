using NUnit.Framework;
using OpenQA.Selenium;
using ToDoList.Models;

namespace ToDoList.Helpers
{
    public class SettingsHelper: HelperBase
    {
        public SettingsHelper(AppManager manager)
            : base(manager)
        {
        }

        public void ChangeEmail(User user, string newEmail)
        {
            driver.FindElement(By.LinkText("Настройка")).Click();
            driver.FindElement(By.LinkText("Изменить e-mail")).Click();
            driver.FindElement(By.Id("user_password")).Click();
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys(user.Password);
            driver.FindElement(By.Id("user_email")).Click();
            driver.FindElement(By.Id("user_email")).Clear();
            driver.FindElement(By.Id("user_email")).SendKeys(newEmail);
            driver.FindElement(By.ClassName("submit")).Click();
        }
    }
}