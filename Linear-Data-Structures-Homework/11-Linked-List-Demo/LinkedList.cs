using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Linked_List_Demo
{
    class LinkedList<T>
    {
        public ListItem<T> FirstElement { get; set; }
        public ListItem<T> LastElement { get; set; }
        public LinkedList()
        {
            this.FirstElement = null;
            this.LastElement = null;
        }

        public void AddLast(T element)
        {
            var newElement = new ListItem<T>(element);
            if(this.FirstElement == null)
            {
                this.FirstElement = newElement;
                this.LastElement = newElement;
            }
            else
            {
                this.LastElement.NextItem = newElement;
                newElement.PreviousItem = this.LastElement;
                this.LastElement = newElement;
            }
        }
        public void AddFirst(T element)
        {
            var newElement = new ListItem<T>(element);
            if(this.FirstElement == null)
            {
                this.FirstElement = newElement;
                this.LastElement = newElement;
            }
            else
            {
                this.FirstElement.PreviousItem = newElement;
                newElement.NextItem = this.FirstElement;
                this.FirstElement = newElement;
            }
        }

        public ListItem<T> RemoveLast()
        {
            if(this.FirstElement == null)
            {
                throw new ArgumentOutOfRangeException("The list is empty.");
            }
            var itemToRemove = this.LastElement;
            this.LastElement.PreviousItem.NextItem = null;
            this.LastElement = this.LastElement.PreviousItem;

            return itemToRemove;
        }
        public ListItem<T> RemoveFirst()
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentOutOfRangeException("The list is empty.");
            }
            var itemToRemove = this.FirstElement;
            this.FirstElement.NextItem.PreviousItem = null;
            this.FirstElement = this.FirstElement.NextItem;

            return itemToRemove;
        }
    }
}
