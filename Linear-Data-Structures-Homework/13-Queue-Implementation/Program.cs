using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Queue_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new QueueImplementation<String>();
            queue.Enqueue("1");
            queue.Dequeue();
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");
            queue.Enqueue("5");

            Console.WriteLine(queue);

        }
    }
}
