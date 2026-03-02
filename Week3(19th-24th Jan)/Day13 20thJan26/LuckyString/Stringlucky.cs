using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyString
{
    internal class Stringlucky
    {
        public string Checkstring(int n,string str)
        {
            if (n > str.Length)
                return "Invalid";

            int half = n / 2;

            for (int i = 0; i <= str.Length - n; i++)
            {
                string sub = str.Substring(i, n);

                // Check if substring contains only P, S, G
                foreach (char c in sub)
                {
                    if (c != 'P' && c != 'S' && c != 'G')
                        goto NextSubstring;
                }

                // Check for n/2 consecutive identical characters
                int count = 1;
                for (int j = 1; j < sub.Length; j++)
                {
                    if (sub[j] == sub[j - 1])
                    {
                        count++;
                        if (count >= half)
                            return "Yes";
                    }
                    else
                    {
                        count = 1;
                    }
                }

            NextSubstring:;
            }

            return "No";
        }
    }
    
}
