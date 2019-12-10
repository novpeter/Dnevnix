using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dnevnix;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;
using Dnevnix.Models;
using Dnevnix.Tests;

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
            var notes = new List<Note>();
            for (var i = 0; i < count; i++)
            {
                notes.Add(new Note
                {
                    Title = TestBase.GenerateRandomString(5),
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

        private static void WriteGroupsToXmlFile(List<Note> notes, StreamWriter writer)
            => new XmlSerializer(typeof(List<Note>)).Serialize(writer, notes);
        
    }
}