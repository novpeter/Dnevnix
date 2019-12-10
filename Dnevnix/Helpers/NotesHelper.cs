using System.Text.RegularExpressions;
using System.Threading;
using Dnevnix.Models;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Dnevnix.Helpers
{
    public class NotesHelper: HelperBase
    {
     
        public NotesHelper(AppManager manager): base(manager)
        {
        }


        public void AddNote(Note note)
        {
            driver.Navigate().GoToUrl("https://dnevnix.ru/index.php/zametka");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Дневник'])[2]/following::a[1]")).Click();
            driver.FindElement(By.XPath("//input[@value='Добавить заметку']")).Click();
            driver.FindElement(By.Id("h2")).Click();
            driver.FindElement(By.Id("h2")).Clear();
            driver.FindElement(By.Id("h2")).SendKeys(note.Title);
            driver.FindElement(By.Id("p")).Click();
            driver.FindElement(By.Id("p")).Click();
            driver.FindElement(By.Id("p")).Clear();
            driver.FindElement(By.Id("p")).SendKeys(note.Text);
            Thread.Sleep(500);
        }
    }
}