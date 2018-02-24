using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            al.Add(200);
           // al.Add(null);
            al.Add(500);
            al.Add(300);
            al.Add(150);
            //al.Add('a');
            //al.Add("Ankit");
            Console.WriteLine(al.Capacity);
            foreach (var i in al)
            {
                Console.Write(i + " " );
            }
            Console.WriteLine();
           al.Insert(3,99);
            foreach (var i in al)
            {
                Console.Write(i + " ");
            }
            //  al.Remove(200);
            al.RemoveAt(3);
            Console.WriteLine();
            foreach (var i in al)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
  }

