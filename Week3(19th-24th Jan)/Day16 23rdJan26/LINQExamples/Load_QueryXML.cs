using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQExamples
{
    internal class Load_QueryXML
    {
        static void Main(string[] args)
        {
            // Step 1: Load XML from file
            XElement students = XElement.Load("students.xml");

            // Step 2: Query with LINQ
            var query = from s in students.Elements("Student")
                        where (int)s.Element("Age") > 20
                        select s.Element("Name").Value;

            // Step 3: Print results
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

        }
    }
}
