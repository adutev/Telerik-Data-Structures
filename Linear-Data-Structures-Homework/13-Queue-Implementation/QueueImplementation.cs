using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Queue_Implementation
{
    class QueueImplementation<T> : IEnumerable<T>
    {

        private List<T> elements;

        public QueueImplementation()
        {
            this.elements = new List<T>();
        }

        public void Enqueue(T value)
        {

            this.elements.Add(value);

        }

        public T Dequeue()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            var elementToRemove = this.elements.First();
            this.elements.RemoveAt(0);
            return elementToRemove;
        }

        public T Peek()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            return this.elements.First();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }
        public override string ToString()
        {
            return String.Join(", ", this);
        }
    }
}
