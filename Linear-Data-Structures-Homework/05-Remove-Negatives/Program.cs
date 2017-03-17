using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Remove_Negatives
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 1, 1, -1, -1, -1, 4, -4, 7, -7, 7, 8, 3, 4, 7, 8, 8, 8, 8 };
            List<int> newList = new List<int>();
            foreach(int num in numbers)
            {
                if(num >= 0)
                {
                    newList.Add(num);
                }
            }
            foreach(var r in newList)
            {
                Console.WriteLine(r);

            }
        }
    }
}
