using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientList
{
    internal class PatientBO
    {
        public void DisplayPatientDetails(List<Patient> patientList, string name)
        {
            List<Patient> p1 = (from p in patientList
                                where p.Name == name
                                select p).ToList();
            int lp = p1.Count;

            if (lp < 0)
            {
                Console.Write("Employee named {0} not found", name); ;
            }
            else
            {

                Console.WriteLine("Name                 Age   Illness              City");
                foreach (Patient x1 in p1)
                {
                    Console.WriteLine(x1.ToString());
                }

            }

        }
        public void DisplayYoungestPatientDetails(List<Patient> patientList)
        {
            int age = (from p in patientList
                       select p.Age).Min();
            var x = from p in patientList
                    where p.Age == age
                    select p;

            Console.WriteLine("Name                 Age   Illness            City");
            foreach (var x1 in x)
            {
                Console.WriteLine(x1.ToString());
            }

        }
        public void displayPatientsFromCity(List<Patient> patientList, string cName)
        {
            List<Patient> p1 = (from p in patientList
                                 where p.City == cName
                                 select p).ToList();
            int lp = p1.Count;

            if (lp < 0)
            {
                Console.Write("Employee named {0} not found", cName); ;
            }
            else
            {

                Console.WriteLine("Name                 Age   Illness              City");
                foreach (Patient x1 in p1)
                {
                    Console.WriteLine(x1.ToString());
                }

            }

        }


    }
}
