using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathoperation
{
    internal class Minoperation
    {
        public  int Minsteps(int n)
        {
            Queue<(int value, int steps)> queue = new Queue<(int, int)>();
            HashSet<int> visited = new HashSet<int>();

            queue.Enqueue((10, 0));
            visited.Add(10);

            while (queue.Count > 0)
            {
                var currentnum = queue.Dequeue();
                int current = currentnum.value;
                int steps = currentnum.steps;

                if (current == n)
                    return steps;

                int next1 = current + 2;
                int next2 = current - 1;
                int next3 = current * 3;

                if (next1 >= 0 && !visited.Contains(next1))
                {
                    visited.Add(next1);
                    queue.Enqueue((next1, steps + 1));
                }

                if (next2 >= 0 && !visited.Contains(next2))
                {
                    visited.Add(next2);
                    queue.Enqueue((next2, steps + 1));
                }

                if (!visited.Contains(next3))
                {
                    visited.Add(next3);
                    queue.Enqueue((next3, steps + 1));
                }
            }

            return -1; // safety fallback
        }
    }
}
