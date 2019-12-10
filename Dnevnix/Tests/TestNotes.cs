using Dnevnix.Models;
using NUnit.Framework;

namespace Dnevnix.Tests
{
    [TestFixture]
    public class TestNotes: TestBase
    {

        [Test, TestCaseSource(nameof(NoteFromXmlFile))]
        public void AddNote(Note note)
        {
            App.Auth.Login(User.current);
            App.Notes.AddNote(note);
        }
    }
}
