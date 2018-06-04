using System;
using System.Collections;

namespace FlowerFieldApp {
    public class Daisychain<T> : IEnumerable, IEnumerator {
        private Daisy<T> first = null;
        private Daisy<T> current = null;
        public int count = -1;

        public void Insert(T value) {
            if (first == null) {
                first = new Daisy<T>(value, current);
                current = first;
            } else {
                current.Next = new Daisy<T>(value, current.Next);
                current = current.Next;
            }
            count++;
        }

        public int Count() {
            return count;
        }

        public void Remove() {
            current = null;
            count--;
        }

        public T GetCurrent() {
            return (T)Current;
        }

        public object Current => current;

        public void Reset() {
            count = 0;
            current = first;
        }

        public bool MoveNext() {
            if (current != null) {
                current = current.Next;
                return true;
            }
            return false;
        }

        public IEnumerator GetEnumerator() {
            return this;
        }
        
        private class Daisy<U> {
            public readonly U Value;
            public Daisy<U> Next;

            public Daisy(U value, Daisy<U> next = null) {
                Value = value;
                Next = next;
            }
        }
    }
}