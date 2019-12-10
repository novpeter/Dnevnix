using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Dnevnix.Models;
using NUnit.Framework;

namespace Dnevnix.Tests
{
    public class TestBase
    {
        protected AppManager App;
        
        private static readonly Random Random = new Random();

        [SetUp]
        public void SetupTest() => App = AppManager.GetInstance();


        protected static IEnumerable<Note> NoteFromXmlFile()
        {
            return (List<Note>)new XmlSerializer(typeof(List<Note>))
                .Deserialize(new StreamReader(@"/Users/petr/Desktop/Dnevnix/Dnevnix/notes.xml"));
        }
        
        public static string GenerateRandomString(int length)
        {
            const string chars = "qwertyuiopasdfghjklzxcvbnm1234567890";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}