using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceString
{
    internal class UserProgramCode
    {
        public static string ReplaceStr(string str,int n,char c)
        {
            foreach (char ch in str)
            {
                if (Char.IsSymbol(ch)) { return "-1"; }
            }
            if (n < 0) { return "-2"; }
            if (!Char.IsSymbol(c)) { return "-3"; }

            string[] arr=str.Split(" ");
            
        }
    }
}
