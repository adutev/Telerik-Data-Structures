using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Longest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 1, 1, 1, 1, 1, 4, 4, 7, 7, 7, 8, 3, 4, 7, 8, 8, 8, 8 };
            int longestSeq = 1;
            int currentSeq = 1;
            int lastIndexOfLongestSeq = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSeq++;
                    if (currentSeq >= longestSeq)
                    {
                        longestSeq = currentSeq;
                        lastIndexOfLongestSeq = i + 1;
                    }
                }
                else
                {
                    currentSeq = 1;
                }
            }
            for (int i = lastIndexOfLongestSeq - longestSeq + 1; i <= lastIndexOfLongestSeq; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
