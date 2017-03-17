using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Remove_Odd_Occurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            List<int> newList = new List<int>();
            foreach (int num in numbers)
            {
                if (numbers.FindAll(x=>x.Equals(num)).Count % 2 == 0)
                {
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
