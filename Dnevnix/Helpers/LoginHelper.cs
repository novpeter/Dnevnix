using System;
using Dnevnix;
using Dnevnix.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Dnevnix.Helpers
{
    public class LoginHelper: HelperBase
    {
        public LoginHelper(AppManager manager)
            : base(manager)
        {
        }

        public void Login(User user)
        {
            driver.FindElement(By.Name("username")).Click();
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys(user.Username);
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys(user.Password);
            driver.FindElement(By.Name("Submit")).Click();
            Assert.AreEqual(
                "Мой дневник", 
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Закрыть'])[2]/following::h2[1]")).Text);
        }
        
        public void LogOut()
        {
            driver.FindElement(By.Name("Submit")).Click();
            Assert.AreEqual(
                "ЗАПОМНИТЬ МЕНЯ", 
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Цитаты'])[2]/following::label[1]")).Text);
        }
    }
}