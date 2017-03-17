using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reverse_Using_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            while(stack.Count!=0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
