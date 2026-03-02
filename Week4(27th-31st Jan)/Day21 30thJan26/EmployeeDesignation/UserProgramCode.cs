using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDesignation
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            string[] res= new string[input1.Length];int k = 0;
            string in2=input2.ToLower();
            for (int i = 1; i < input1.Length; i++)
            {
                string in1=input1[i].ToLower();
                //Console.WriteLine(input1[i]);
                if (in1==in2)
                {
                    res[k] = input1[i-1];
                    //Console.WriteLine(res[k]);
                    k++;
                }
                i++;
            }
            return res;

        }
    }
}
