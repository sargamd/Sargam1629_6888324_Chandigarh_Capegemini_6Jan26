using System.Xml.Linq;

namespace LINQExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement students = new XElement("Students",
                new XElement("Student",
                new XAttribute("Id", 1),
                new XElement("Name", "Alice"),
                new XElement("Age", 20)
            ),
                new XElement("Student",
                new XAttribute("Id", 2),
                new XElement("Name", "Bob"),
                new XElement("Age", 22)
                )
            );
            Console.WriteLine(students);
            students.Save("students.xml");




        }
    }
}
