using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcollection
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "A");
            d.Add(2, "B");
            d.Add(3, "C");
            d.Add(6, "D");
            d.Add(4, "E");
            d.Add(5, "F");

            foreach (KeyValuePair<int, string> kv in d)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.WriteLine("================");
            Console.WriteLine(d.ContainsKey(2));
            Console.WriteLine("===============");
            Console.WriteLine(d.ContainsValue("D"));

            Console.Read();
        }
       
    }
}
