using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class ClassC : Interface1, Interface2
    {
        void Interface1.f1()
        {
            Console.WriteLine("Interface 1");
        }
        void Interface2.f1()
        {
            Console.WriteLine("Interface 2");
        }
    }
    
    
}
