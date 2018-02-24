using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleAppcollection
{
    class QueueProgramm
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);

            q.Enqueue(5);
            q.Enqueue(2);
            q.Enqueue(3);

            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue("Ankit");
            q.Enqueue(5);
            q.Enqueue(6);

            
            Console.WriteLine("===============");
            IEnumerator ae = q.GetEnumerator();
            while (ae.MoveNext())
            {
                Console.WriteLine(ae.Current);

            }

            Console.WriteLine("===============");
            q.Dequeue();
            IEnumerator a1 = q.GetEnumerator();
            while (a1.MoveNext())
            {
                Console.WriteLine(a1.Current);

            }

            Console.WriteLine("===============");
            Console.WriteLine(q.Peek());
            Console.WriteLine("===============");
            
            IEnumerator a2 = q.GetEnumerator();
            while (a2.MoveNext())
            {
                Console.WriteLine(a2.Current);

            }



            Console.Read();
        }
    }
}
