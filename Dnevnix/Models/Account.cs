namespace Dnevnix.Models
{
    public struct User
    {
        public static User current = new User { Username = "wofanis304@mailapp.top", Password = "Qwerty123" };
        
        public string Username;
        public string Password;
    }
}