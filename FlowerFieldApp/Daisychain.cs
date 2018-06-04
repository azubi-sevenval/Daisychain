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

        // Methodendeklaration
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

        // <summary>
        // Removes the current element of the collection and makes the next element the current element if available.
        // </summary>
        public void Remove()
        {
            // current = null;
            // count--
        }

        /// <summary>
        /// Gets the value of the element in the collection at the current position of the iteration.
        /// </summary>
        /// <returns></returns>
        public T GetCurrent() { return (T)Current; } // type save

        /// <summary>
        /// Gets the value of the element in the collection at the current position of the iteration.
        /// Implementation of IEnumerator-interface.
        /// </summary>
        public object Current { get { return this.current; } }

        /// <summary>
        /// Sets the iteration to its initial position, which is just before the first element.
        /// Implementation of IEnumerator-interface.
        /// </summary>
        public void Reset() { throw new NotImplementedException("please implement missing code here"); }

        /// <summary>
        /// Advances the iteration to the next element of the collection starting from current.
        /// Implementation of IEnumerator-interface.
        /// </summary>
        /// <returns>true if the iteration was successfully advanced to the next element;
        /// false if the iteration has passed the end of the collection.</returns>
        public bool MoveNext()
        {
            return current != null ? true : false;
        }
        /// <summary>
        /// Returns this as enumerator.
        /// Implementation of the IEnumerable-interface.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator() { Reset(); return this; }
    }
}
