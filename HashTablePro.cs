using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppcollection
{
    class HashTablePro
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
         
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(5,"five");
            ht.Add(0,"zero");
            ht.Add(3,"three");
            ht.Add(4,"four");

            foreach (DictionaryEntry i in ht)
            {
                int key = (int)i.Key;
                string value = i.Value.ToString();
                Console.WriteLine(key + " " + value);

            }


            ht.Remove(2);

            Console.WriteLine("After removing the ...");
            foreach (DictionaryEntry i in ht)
            {
                int key = (int)i.Key;
                string value = i.Value.ToString();
                Console.WriteLine(key + " " + value);

            }

            Console.WriteLine("All keys no...");
            foreach (int i in ht.Keys)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("All values no...");
            foreach (string i in ht.Values)
            {
                Console.WriteLine(i);
            }

            

            Console.WriteLine("Some method used of hashtable");
            Console.WriteLine( ht.ContainsValue("two"));
           Console.WriteLine(ht.ContainsKey(3));
           Console.WriteLine(ht.Contains(9));

            Console.Read();
        }
    }
}
