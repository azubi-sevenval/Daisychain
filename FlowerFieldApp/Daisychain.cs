using System;
using System.Collections;

namespace FlowerFieldApp {
  public class Daisychain<T> : IEnumerable, IEnumerator {
    private Daisy<T> first = null;
    private Daisy<T> current = null;
    public int count;

    public void Insert(T value) {
      Daisy<T> daisy = new Daisy<T>(value);
        if (first == null) {
          first = daisy;
          current = first;
        } else if(current.Next == null) {
          current.Next = daisy;
          current = daisy;
        }
        count++;
      }

    public int Count() {
      return this.count;
    }

    public void Remove() {
      current = null;
      count--;
    }

    public bool Contains(string str){
      return true;
    }

    public T GetCurrent() { return (T)Current; }

    public object Current { get { return this.current.Value; } }

    public void Reset() {
      current = null;
    }

    public bool MoveNext() {
      if(current == null) {
        current = first;
        return true;
      } else if(current.Next != null) {
        current = current.Next;
        return true;
      } else {
        return false;
      }
    }

    public IEnumerator GetEnumerator() { Reset(); return this; }

    private class Daisy<U> {
      public readonly U Value;
      public Daisy<U> Next;

      public Daisy(U value, Daisy<U> next = null) {
        this.Value = value;
        this.Next = next;
      }
    }
  }
}
