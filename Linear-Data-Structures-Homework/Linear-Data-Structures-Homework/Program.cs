using System;
using System.Collections.Generic;

namespace Linear_Data_Structures_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            var numbers = new List<int>();
            int sum = 0;
            double average = 0;

            while (int.TryParse(Console.ReadLine(), out n))
            {
                sum += n;
                numbers.Add(n);
            }
            Console.WriteLine($"the sum is: {sum}. Avg: {sum/(double)numbers.Count}");


        }
    }
}
