using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListElements
{
    internal class UserProgramCode
    {
        public static List<int> getElements(List<int> input1,int input2)
        {
            //if (input1.Count == 0) { return new List<int>(-1); }
            List<int> result = new List<int>();
            foreach(int i in input1)
            {
                if (i < input2)
                {
                    result.Add(i);
                }
            }
            
            result.Sort();
            result.Reverse();
            return result;
        }
    }
}
