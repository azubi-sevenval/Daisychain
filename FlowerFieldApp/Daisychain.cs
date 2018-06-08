/*
 * fn@gso-koeln.de 2018
 */
using System;
using System.Collections;

namespace FlowerFieldApp
{
    public class Daisychain<T> : IEnumerable, IEnumerator
    {
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
            current = null;
            count--;
        }

        public T GetCurrent() { return (T)Current; } // type save

        public object Current { get { return this.current; } }

        public void Reset() {
            count = -1;
            current = first;
        }

        public bool MoveNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator GetEnumerator() { Reset(); return this; }

        private class Daisy<U>
        {
            public readonly U Value;
            public Daisy<U> Next;

            public Daisy(U value, Daisy<U> next = null)
            {
                this.Value = value;
                this.Next = next;
            }
        }
    }
}
