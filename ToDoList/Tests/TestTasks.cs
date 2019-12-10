using System;
using NUnit.Framework;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestFixture]
    public class TestTasks: AuthBase
    {

        [Test, TestCaseSource(nameof(NoteFromXmlFile))]
        public void AddTask(Task task)
        {
            App.Navigation.NavigateToPage(Path.ListsPage);
            App.Task.AddTask(task);
        }
    }
}
