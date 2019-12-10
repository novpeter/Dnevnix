using System;
using System.Text;
using System.Threading;
using Dnevnix.Helpers;
using Dnevnix.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dnevnix
{
    public class AppManager
    {
        private StringBuilder _verificationErrors;

        public IWebDriver Driver { get; }
        public NavigationHelper Navigation { get; }
        public LoginHelper Auth { get; }
        public NotesHelper Notes { get; }
        public SettingsHelper Settings { get; }
        
        public AssertHelper Assert { get; }
        
        private static ThreadLocal<AppManager> _app = new ThreadLocal<AppManager>();


        private AppManager()
        {
            Driver = new ChromeDriver(@"/Users/petr/Downloads/");
            _verificationErrors = new StringBuilder();
            Notes = new NotesHelper(this);
            Settings = new SettingsHelper(this);
            Auth = new LoginHelper(this);
            Assert = new AssertHelper(this);
            Navigation = new NavigationHelper(this, "");
        }

        public void Stop() => Driver.Quit();
        
        public static AppManager GetInstance()
        {
            if (_app.IsValueCreated) return _app.Value;
            var newInstance = new AppManager();
            newInstance.Navigation.NavigateToPage(Path.HomePage);
            _app.Value = newInstance;
            return _app.Value;
        }

        ~AppManager()
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception)
            {
                //ignore
            }
        }
    }
}