using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_Vowel
{
    internal class StringVowels
    {
        public string Stringprocess(string word1, string word2)
        {
            string vowels = "aeiouAEIOU";
            string temp = "";

           
            for (int i = 0; i < word1.Length; i++)
            {
                char c = word1[i];
                char lowerC = char.ToLower(c);

                bool isVowel = vowels.IndexOf(c) != -1;
                bool isCommon = word2.ToLower().IndexOf(lowerC) != -1;

                if (isVowel || !isCommon)
                {
                    temp += c;
                }
            }

           
            if (temp.Length == 0)
                return "";

            string result = "";
            result += temp[0];

            for (int i = 1; i < temp.Length; i++)
            {
                if (char.ToLower(temp[i]) != char.ToLower(temp[i - 1]))
                {
                    result += temp[i];
                }
            }

            return result;
        }
    }
    
}
