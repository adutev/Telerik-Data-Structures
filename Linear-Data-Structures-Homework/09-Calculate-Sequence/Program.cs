using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Calculate_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int n = 2;
            int count = 1;
            queue.Enqueue(n);
            while(count < 50)
            {
                int r = queue.Dequeue();
                Console.Write(r + " ");
                queue.Enqueue(r + 1);
                count++;
                queue.Enqueue(r * 2 + 1);
                queue.Enqueue(r + 2);
            }
            Console.WriteLine(queue.Dequeue());
        }
    }
}
