using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Shortest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
              
            int n = 5;
            int m = 141;
            queue.Enqueue(m);
            while (m/2 !=0)
            {
                
                if(m/2 > n)
                {
                    if (m % 2 == 1)
                    {
                        queue.Enqueue(m - 1);
                        m = m - 1;
                    } else
                    {
                        queue.Enqueue(m / 2);
                        m = m / 2;
                    }
                }
                else if(m/2 == n)
                {
                    queue.Enqueue(m / 2);
                    break;
                }
                else if(m - 2 > n)
                {
                    queue.Enqueue(m - 2);

                    m = m - 2;
                }
                else if(m - 2 == n)
                {
                    queue.Enqueue(m - 2);
                    break;
                }

                else if (m - 1 > n)
                {
                    queue.Enqueue(m - 1);

                    m = m - 1;
                }
                else if (m - 1 == n)
                {
                    queue.Enqueue(m - 1);
                    break;
                }
            }


            while (queue.Count!=0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }
    }
}
