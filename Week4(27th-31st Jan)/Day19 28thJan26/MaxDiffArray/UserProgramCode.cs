using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDiffArray
{
    internal class UserProgramCode
    {
        public static int diffIntArray(int[] input1)
        {
            int max = 0;
            for(int i = 0; i < input1.Length; i++)
            {
                for(int j=i+1;j<input1.Length; j++)
                {
                    if (input1[i] < input1[j])
                    {
                        int diff = input1[j] - input1[i];
                        if (diff > max) { max= diff; }
                    }
                }
            }
            return max;
        }
    }
}
