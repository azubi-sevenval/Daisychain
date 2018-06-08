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
        private Daisy<T> previous = null;
        public int count;

        public void Insert(T value)
        {
            Daisy<T> daisy = new Daisy<T>(value);
            if (first == null)
            {
                first = daisy;
                current = first;
                previous = first;
                Console.WriteLine(first.Value);
            }
            else
            {
                if(current.Next == null)
                {
                    current.Next = daisy;
                    previous = current;
                    current = daisy;
                    Console.WriteLine(current.Value);
                }
            }
            count++;
        }

        public int Count() { return this.count; }

        public void Remove()
        {
            previous.Next = current.Next.Next;
            current = null;
            count--;
        }

        public bool Contains(string str)
        {

            return true;
        }

        public T GetCurrent() { return (T)Current; } // type save

        public object Current { get { return this.current.Value; } }

        public void Reset() {
            current = null;
            // current = first;
        }

        public bool MoveNext()
        {
            if(current == null)
            {
                current = first;
                return true;
            } else
            {
                if(current.Next != null)
                {
                    current = current.Next;
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public IEnumerator GetEnumerator() { Reset(); return this; }
    }
}
