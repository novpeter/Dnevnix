using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Tests;
using Task = ToDoList.Models.Task;

namespace Dnevnix
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = args[0];
            var count = Convert.ToInt32(args[1]);
            var filename = args[2];
            var format = args[3];

            if (type == "notes") GenerateForNotes(count, filename, format);
            else Console.Out.Write("Unrecognized type of data " + type);
        }

        private static void GenerateForNotes(int count, string filename, string format)
        {
            var notes = new List<Task>();
            for (var i = 0; i < count; i++)
            {
                notes.Add(new Task
                {
                    Text = TestBase.GenerateRandomString(20)
                });
            }

            if (format == "xml")
            {
                var writer = new StreamWriter(filename);
                WriteGroupsToXmlFile(notes, writer);
                writer.Close();
            }
            else Console.Out.Write("Unrecognized format" + format);
            
        }

        private static void WriteGroupsToXmlFile(List<Task> notes, StreamWriter writer)
            => new XmlSerializer(typeof(List<Task>)).Serialize(writer, notes);
        
    }
}