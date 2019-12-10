using NUnit.Framework;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestFixture]
    public class TestTasks: TestBase
    {

        [Test, TestCaseSource(nameof(NoteFromXmlFile))]
        public void AddTask(Task task)
        {
            App.Auth.Login(User.Current);
            App.Task.AddTask(task);
            App.Auth.LogOut();
        }
    }
}
