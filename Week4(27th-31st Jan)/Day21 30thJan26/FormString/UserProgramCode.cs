using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormString
{
    internal class UserProgramCode
    {
        public static string formString(string[] input1, int input2)
        {
            string res = "";
            foreach(string s in input1)
            {
                if (s.Length < input2) { res = res + "$"; }
                else { res = res + s[input2 - 1]; }
            }
            return res;
        }
    }
}
