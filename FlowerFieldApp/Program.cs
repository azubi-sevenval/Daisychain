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

            //int[] a = { 100, 200, 300 };
            //ShowCollection(a);

            //List<string> b = new List<string>(new string[] { "Hugo", "Helga", "Holger" });
            //ShowCollection(b);

<<<<<<< HEAD
            Customer c1 = new Customer("Hugo", "Hiller");
            Customer c2 = new Customer("Helga", "Hermsdorf");
            Customer c3 = new Customer("Holger", "Hollein");
=======
            //
            // demonstrate the usage of DasyChain
            //
            Customer c1 = new Customer("1Hugo", "Hiller");
            Customer c2 = new Customer("2Helga", "Hermsdorf");
            Customer c3 = new Customer("3Holger", "Hollein");
<<<<<<< HEAD
=======
            Customer c4 = new Customer("4Hermann", "Hoffmann");
>>>>>>> 9a55b0bcb21e68c9d484e0b909880ec565aac6fb
>>>>>>> marvin

            try {
                Daisychain<Customer> c = new Daisychain<Customer>();
                c.Insert(c1);
                c.Insert(c2);
                c.Insert(c3);
                ShowCollection(c);
            } catch {
                Console.WriteLine("\nDaisychain is not successfully implemented!!!");
            }
            
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
