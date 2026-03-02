using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToDecimal
{
    internal class UserProgramCode
    {
        public static int convertRomanToDecimal(string input)
        {
            int output = 0;
            foreach (char c in input)
            {
                if (c != 'I' && c != 'V' && c != 'X' && c != 'C' && c != 'L' && c != 'M' && c != 'D')
                {
                    return -1;
                }
            }
            Dictionary<char, int> list = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'C', 100},
                {'L', 50},
                {'D', 500},
                {'M', 1000}
            };
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (list[input[i]] < list[input[i + 1]])
                {
                    output -= list[input[i]];
                }
                else output += list[input[i]];
            }
            output += list[input[input.Length - 1]];
            return output;

        }
    }
}
