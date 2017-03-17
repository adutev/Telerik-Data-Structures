using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Find_Occurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            numbers.Sort();
            List<int> newList = new List<int>();
            foreach (int num in numbers)
            {
                if (!newList.Contains(num))
                {
                    Console.WriteLine($"{num} -> {numbers.FindAll(x => x.Equals(num)).Count} times");
                    newList.Add(num);
                }
            }
            foreach (var r in newList)
            {
                Console.Write(r);

            }
        }
    }
}
