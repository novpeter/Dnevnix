using System;
using System.Threading;
using ToDoList;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ToDoList.Models;

namespace ToDoList.Helpers
{
    public class LoginHelper: HelperBase
    {
        public LoginHelper(AppManager manager)
            : base(manager)
        {
        }

        public void Login(User user)
        {
            driver.FindElement(By.LinkText("Вход")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("user_login")).Clear();
            driver.FindElement(By.Id("user_login")).SendKeys(user.Username);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys(user.Password);
            driver.FindElement(By.ClassName("submit")).Click(); 
            Assert.AreEqual("Списки задач", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Настройка'])[1]/following::h2[1]")).Text);;
            Thread.Sleep(3000);
        }
        
        public void LogOut()
        {
            driver.Navigate().GoToUrl("http://todolist.ru/todolist/index.html");
            driver.FindElement(By.LinkText("Выход")).Click();
            Assert.AreEqual("Вход", driver.FindElement(By.LinkText("Вход")).Text);
        }
    }
}