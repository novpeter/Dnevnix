using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using ToDoList.Models;

namespace ToDoList.Helpers
{
    public class TaskHelper: HelperBase
    {
     
        public TaskHelper(AppManager manager): base(manager)
        {
        }


        public void AddTask(Task task)
        {
            driver.FindElement(By.Id("content")).Click();
            Assert.AreEqual("Testing", driver.FindElement(By.LinkText("Testing")).Text);
            driver.FindElement(By.LinkText("Testing")).Click();
            driver.FindElement(By.LinkText("Добавить задачу")).Click();
            driver.FindElement(By.XPath("//input[@name='']")).Clear();
            driver.FindElement(By.XPath("//input[@name='']")).SendKeys(task.Text);
            driver.FindElement(By.XPath("(//input[@name=''])[2]")).Click();
            Thread.Sleep(500);
        }
    }
}