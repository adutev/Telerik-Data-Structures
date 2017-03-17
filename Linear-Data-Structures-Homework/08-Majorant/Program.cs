using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _08_Majorant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int n = numbers.Count;
            bool hasResult = false;
            int result = 0;
            numbers.Sort();
            foreach (int num in numbers)
            {
                if (numbers.FindAll(x => x.Equals(num)).Count == n/2 + 1)
                {
                    hasResult = true;
                    result = num;
                }
            }
            if(hasResult)
            {
                Console.WriteLine("Majorant " + result);

            }
        }
    }
}
