using System;
using System.Xml;

namespace ToDoList
{
    public static class Settings
    {
        private const string File = "/Users/petr/Desktop/Testing/Coding/ToDoList/ToDoList/settings.xml";

        private static string _baseUrl;
        private static string _wrongPassword;
        private static string _password;
        private static string _userName;
        
        private static readonly XmlDocument Document;

        static Settings()
        {
            if (!System.IO.File.Exists(File)) { throw new Exception("Problem: settings file not found: " + File); }
            Document = new XmlDocument();
            Document.Load(File);
        }

        public static string BaseUrl
        {
            get
            {
                if (_baseUrl != null) return _baseUrl;
                var node = Document.DocumentElement.SelectSingleNode("BaseUrl");
                _baseUrl = node.InnerText;
                return _baseUrl;
            }
        }

        public static string Password
        {
            get
            {
                if (_password != null) return _password;
                var node = Document.DocumentElement.SelectSingleNode("Password");
                _password = node.InnerText;
                return _password;
            }
        }

        public static string WrongPassword
        {
            get
            {
                if (_wrongPassword != null) return _wrongPassword;
                var node = Document.DocumentElement.SelectSingleNode("WrongPassword");
                _wrongPassword = node.InnerText;
                return _wrongPassword;
            }
        }

        public static string UserName
        {
            get
            {
                if (_userName != null) return _userName;
                var node = Document.DocumentElement.SelectSingleNode("UserName");
                _userName = node.InnerText;
                return _userName;
            }
        }
	
    }
}