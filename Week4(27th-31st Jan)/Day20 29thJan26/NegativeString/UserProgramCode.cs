using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NegativeString
{
    internal class UserProgramCode
    {
        public static string NegativeStr(string str)
        {
            string output = Regex.Replace(str, @"\bis\b", "is not");
            return output;
            //return str;
        }
    }
}
