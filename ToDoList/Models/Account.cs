namespace ToDoList.Models
{
    public struct User
    {
        public static User Current = new User { Username = "vover61220", Password = "Qwerty123" };
        
        public string Username;
        public string Password;
    }
}