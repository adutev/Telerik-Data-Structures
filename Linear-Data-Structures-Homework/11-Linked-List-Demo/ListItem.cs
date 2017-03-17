using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Linked_List_Demo
{
    class ListItem<T>
    {
        public T Value { get;  set; }
        public ListItem<T> NextItem { get;  set; }
        public ListItem<T> PreviousItem { get; set; }


        public ListItem(T value)
        {
            this.Value = value;
            this.NextItem = null;
            this.PreviousItem = null;
        }
    }
}
//Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).