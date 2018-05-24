/*
 * fn@gso-koeln.de 2018
 */
using System;
using System.Collections;

namespace FlowerFieldApp
{
    /// <summary>
    /// Collection of chained values which can be iterated in one direction
    /// </summary>
    /// <typeparam name="T">Value type</typeparam>
    public class Daisychain<T> : IEnumerable, IEnumerator
    {
        /// <summary>
        /// First element of the collection to start iterations from
        /// </summary>
        private Daisy<T> first = null;

        /// <summary>
        /// Current element of the iteration
        /// </summary>
        private Daisy<T> current = null;

        /// <summary>
        /// Gets the count of contained elements of the collection.
        /// </summary>
        public int Count { get { throw new NotImplementedException("please implement missing code here"); } }

        /// <summary>
        /// Inserts an element containing the given value after the current element.
        /// If the collection is empty or the iterarion is reset a new first element is being inserted.
        /// </summary>
        /// <param name="value"></param>
        public void Insert(T value) {
			if (first == null) {
				first = new Daisy<T> (value, current);
			} else if (current == null) {
				current = new Daisy<T> (value, current.Next);
			} else {
				current.Next = new Daisy<T> (value, current.Next);
				MoveNext ();
			}
		}

        /// <summary>
        /// Removes the current element of the collection and makes the next element the current element if available.
        /// </summary>
        public void Remove() { throw new NotImplementedException("please implement missing code here"); }

        /// <summary>
        /// Gets the value of the element in the collection at the current position of the iteration.
        /// </summary>
        /// <returns></returns>
        public T GetCurrent() { return (T)Current; } // type save

        /// <summary>
        /// Gets the value of the element in the collection at the current position of the iteration.
        /// Implementation of IEnumerator-interface.
        /// </summary>
        public object Current { get { { throw new NotImplementedException("please implement missing code here"); } } }

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
        public bool MoveNext() {
			return this.MoveNext ();
		}

        /// <summary>
        /// Returns this as enumerator.
        /// Implementation of the IEnumerable-interface.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator() { Reset(); return this; }

        /// <summary>
        /// Daisychained element of the collection containing the listed value.
        /// The element is structured recursively to build the collection.
        /// </summary>
        /// <typeparam name="T">Value type</typeparam>
        private class Daisy<U>
        {
            /// <summary>
            /// Constructs a new collection element
            /// </summary>
            /// <param name="value">Value of the collections element</param>
            /// <param name="next">Next element of the collection or 'null' at last element</param>
            public Daisy(U value, Daisy<U> next = null) {
                this.Value = value;
                this.Next = next;
            }

            /// <summary>
            /// Value of the collections element
            /// </summary>
            public readonly U Value;

            /// <summary>
            /// Next element of the collection or 'null' at last element
            /// </summary>
            public Daisy<U> Next;
        }
    }
}
