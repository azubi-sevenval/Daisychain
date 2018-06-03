/*
 * fn@gso-koeln.de 2018
 */
using System;
using System.Collections;

namespace FlowerFieldApp
{
    public class Daisychain<T> : IEnumerable, IEnumerator
    {
        private class Daisy<T>
        {
            public readonly T Value;
            public Daisy<T> Next;

            public Daisy(T value, Daisy<T> next = null)
            {
                this.Value = value;
                this.Next = next;
            }
        }

        private Daisy<T> first = null;
        private Daisy<T> current = null;
        public int count;

        public void Insert(T value)
        {
            Daisy<T> daisy = new Daisy<T>(value);
            if (first == null)
            {
                first = daisy;
                current = first;
                Console.WriteLine(first.Value);
            }
            else
            {
                if(current.Next == null)
                {
                    current.Next = daisy;
                    current = daisy;
                    Console.WriteLine(current.Value);
                }
            }
            count++;
        }

        public int Count() { return this.count; }

        public void Remove()
        {
            //current = null;
            //count--;
        }

        public T GetCurrent() { return (T)Current; } // type save

        public object Current { get { return this.current; } }

        /// <summary>
        /// Sets the iteration to its initial position, which is just before the first element.
        /// Implementation of IEnumerator-interface.
        /// </summary>
        public void Reset() {
            count = -1;
            current = first;
        }

        /// <summary>
        /// Advances the iteration to the next element of the collection starting from current.
        /// Implementation of IEnumerator-interface.
        /// </summary>
        /// <returns>true if the iteration was successfully advanced to the next element;
        /// false if the iteration has passed the end of the collection.</returns>
        public bool MoveNext()
        {
            if (current.Next != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
                return true;
            }
            else
            {
                Console.WriteLine(current.Value);
                return false;
            }
        }

        /// <summary>
        /// Returns this as enumerator.
        /// Implementation of the IEnumerable-interface.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator() { Reset(); return this; }
    }
}
