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
        public static bool IsLoggedIn { get; private set; }

        public static void SetLoggedIn(bool isLoggedIn)
        {
            IsLoggedIn = isLoggedIn;
        }
        
        public LoginHelper(AppManager manager)
            : base(manager)
        {
            IsLoggedIn = false;
        }

        public void Login(User user)
        {
            driver.Navigate().GoToUrl("http://todolist.ru/user/login.html");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("user_login")).Clear();
            driver.FindElement(By.Id("user_login")).SendKeys(user.Username);
            Thread.Sleep(1500);
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys(user.Password);
            driver.FindElement(By.ClassName("submit")).Click(); 
            Assert.AreEqual("Списки задач", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Настройка'])[1]/following::h2[1]")).Text);;
            Thread.Sleep(1000);
        }
        
        public void LogOut()
        {
            driver.Navigate().GoToUrl("http://todolist.ru/todolist/index.html");
            driver.FindElement(By.LinkText("Выход")).Click();
            Assert.AreEqual("Вход", driver.FindElement(By.LinkText("Вход")).Text);
        }
    }
}