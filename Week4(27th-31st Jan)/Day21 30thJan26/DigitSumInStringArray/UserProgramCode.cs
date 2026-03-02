using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSumInStringArray
{
    internal class UserProgramCode
    {
        public static int sumOfDigits(string[] input1)
        {
            int sum = 0;
            foreach (string s in input1)
            {
                for(int i=0;i<s.Length; i++)
                {
                    if (Char.IsSymbol(s[i])) { return -1; }
                    if (Char.IsNumber(s[i]))
                    {                       
                        sum = sum + Convert.ToInt32(s[i]-'0');
                        //Console.WriteLine(Convert.ToInt32(s[i]-'0'));
                    }
                }
            }
            return sum;
        }
    }
}
