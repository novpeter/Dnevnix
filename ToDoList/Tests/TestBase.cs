using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Serialization;
using NUnit.Framework;
using ToDoList.Models;

namespace ToDoList.Tests
{
    public class TestBase
    {
        protected AppManager App;
        
        private static readonly Random Random = new Random();

        [SetUp]
        public void SetupTest() => App = AppManager.GetInstance();

        [TearDown]
        public void TearDown()
        {
            App.Navigation.NavigateToPage(Settings.BaseUrl);
            Thread.Sleep(1500);
        }

        protected static IEnumerable<Task> NoteFromXmlFile()
        {
            return (List<Task>)new XmlSerializer(typeof(List<Task>))
                .Deserialize(new StreamReader(@"/Users/petr/Desktop/Testing/Coding/ToDoList/ToDoList/notes.xml"));
        }
        
        public static string GenerateRandomString(int length)
        {
            const string chars = "qwertyuiopasdfghjklzxcvbnm1234567890";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}