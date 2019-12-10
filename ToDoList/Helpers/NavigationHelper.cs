namespace ToDoList.Helpers
{
    public class NavigationHelper: HelperBase
    {
        private string _baseUrl;  
        
        public NavigationHelper(AppManager manager, string baseUrl)
            : base(manager)
        {
            this._baseUrl = baseUrl;
        }
        
        public void NavigateToPage(string path) => driver.Navigate().GoToUrl(path);
    }
}