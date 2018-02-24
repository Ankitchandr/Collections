using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleAppcollection
{
    class StackProgram
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(null);
            s.Push("ankit");
            s.Push(4);
            s.Push(7);
            s.Push(8);
           

           IEnumerator ae = s.GetEnumerator();
            while (ae.MoveNext())
            {
                Console.WriteLine(ae.Current);
             }


            Console.WriteLine("pop method of stack i am using");
            Console.WriteLine(s.Pop());


            Console.WriteLine("=============================");
            IEnumerator a = s.GetEnumerator();
            while (a.MoveNext())
            {
                Console.WriteLine(a.Current);
            }


            Console.WriteLine("peek method of stack i am using");
            Console.WriteLine(s.Peek());


            Console.WriteLine("=============================");
            IEnumerator a1 = s.GetEnumerator();
            while (a1.MoveNext())
            {
                Console.WriteLine(a1.Current);
            }

            s.Clear();

            Console.WriteLine("=============================");
            IEnumerator a2 = s.GetEnumerator();
            while (a2.MoveNext())
            {
                Console.WriteLine(a2.Current);
            }


            Console.Read();
        }
    }
}
