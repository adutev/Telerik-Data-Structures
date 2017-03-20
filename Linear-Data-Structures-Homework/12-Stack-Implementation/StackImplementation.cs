using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _12_Stack_Implementation
{
    class StackImplementation<T> : IEnumerable
    {
        private const int INITIAL_CAPACITY = 4;
        private T[] elements;
        private int capacity;
        private int lastIndex;
        public int Count { get; private set; }

        public StackImplementation()
        {
            this.capacity = INITIAL_CAPACITY;
            this.elements = new T[capacity];
            this.Count = 0;
            this.lastIndex = 0;
        }

        public void Push(T value)
        {
            if (this.Count == this.capacity)
            {
                Resize();
            }
            this.elements[this.lastIndex] = value;
            this.lastIndex++;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("Stack is empty.");
            }
            var elementToDelete = this.elements[this.lastIndex - 1];
            this.lastIndex--;
            this.Count--;

            return elementToDelete;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("Stack is empty.");
            }
            return this.elements[this.lastIndex - 1];
        }
        private void Resize()
        {
            this.capacity = this.capacity * 2;
            Array.Resize(ref this.elements, capacity);

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
