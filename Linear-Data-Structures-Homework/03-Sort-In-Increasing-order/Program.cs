using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sort_In_Increasing_order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            var numbers = new List<int>();

            while (int.TryParse(Console.ReadLine(), out n))
            {
                numbers.Add(n);
            }
           
            numbers.Sort();
           // numbers.Reverse();
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
