using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMarks
{
    internal class TotalMarks
    {
        public void Validmarks(int x, int y, int n1, int n2, int m)
        {
            int t1=0, t2=0;int type1correct=0, type2correct=0;int ans=0;
            if (m > (x * n1 + y * n2)) { Console.WriteLine("Invalid"); return; }
            else if (m == (x * n1 + y * n2))
            {
                Console.WriteLine("Valid");
                Console.WriteLine(n1);Console.WriteLine(n2);
            }
            
            else
            {
                for (int i = n1; i>=0; i--)
                {
                    t1 = i * x;
                    int r = m - t1;
                    if(r< 0) { continue; }
                    if (r % y == 0)
                    {
                        int j = r / y;
                        if (j <= n2)
                        {
                            type1correct = i;
                            type2correct=j;
                            ans = 1;
                            break;
                        }
                    }
                }
                if (ans == 1)
                {
                    Console.WriteLine("Valid");
                    Console.WriteLine(type1correct);Console.WriteLine(type2correct);
                }
                else { Console.WriteLine("Invalid"); }
            }

        }
    }
}
