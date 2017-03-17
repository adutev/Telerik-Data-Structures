using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Linked_List_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new ListItem<int>(10);
            var l = new LinkedList<int>();
            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);
            l.AddFirst(0);
            Console.WriteLine($"{l.RemoveFirst().Value} is removed");
            Console.WriteLine($"{l.RemoveFirst().Value} is removed");

            for (ListItem<int> n = l.FirstElement; n != null; n = n.NextItem)
            {
                Console.WriteLine(n.Value);
            }
            
        }
    }
}
