/*
 * fn@gso-koeln.de 2018
 */
using System;
using System.Collections.Generic;

namespace FlowerFieldApp
{
    class Program
    {
        static void Main(string[] args) {
            //
            // demonstrate the usage of IEnumerator (and IEnumerator<T>)
            //
            // array
            int[] a = { 100, 200, 300 };
            ShowCollection(a);

            // List<string>
            List<string> b = new List<string>(new string[] { "Hugo", "Helga", "Holger" });
            ShowCollection(b);

            //
            // demonstrate the usage of DasyChain
            //
            Customer c1 = new Customer("Hugo", "Hiller");
            Customer c2 = new Customer("Helga", "Hermsdorf");
            Customer c3 = new Customer("Holger", "Hollein");

            try {
                Daisychain<Customer> c = new Daisychain<Customer>();
                c.Insert(c3);
                c.Insert(c2);
                c.Insert(c1);
                ShowCollection(c);
            } catch {
                Console.WriteLine("\nDaisychain is not successfully implemented!!!");
            }

            //
            // end of program
            //
            Console.WriteLine("\nDone.");
            Console.ReadLine();
        }

        static void ShowCollection(System.Collections.IEnumerable a) {
            Console.WriteLine("\n*** explicit enumerator");
            System.Collections.IEnumerator ea = a.GetEnumerator();
            ea.Reset();
            while (ea.MoveNext()) {
                Console.WriteLine(ea.Current);
            }
            Console.WriteLine("\n*** foreach");
            foreach (object i in a) Console.WriteLine(i);
        }
    }
}
