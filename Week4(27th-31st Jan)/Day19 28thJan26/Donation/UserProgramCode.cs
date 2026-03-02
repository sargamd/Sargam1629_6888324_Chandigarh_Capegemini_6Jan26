using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation
{
    internal class UserProgramCode
    {
        public static int getDonation(string[] input1, int input2)
        {
            string num = input2.ToString();int sum=0;
            
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i].Substring(3, 3) == num)
                {
                    int money = Convert.ToInt32(input1[i].Substring(6,3));
                    sum = sum + money;
                }                
            }
            return sum;
        }
    }
}
