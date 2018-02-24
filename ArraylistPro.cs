using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace ConsoleAppcollection
{

    class Student:IComparable
    {
        public int Id;
        public String Name;
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine(Id +"  " + Name);
        }

        public int CompareTo(object obj)
        {
           
         Student other = (Student)obj;
            if (this.Id < other.Id)
                return -1;
            else if (this.Id > other.Id)
                return 1;
            else
                return 0;

        }
    }

  class ArraylistPro
    {
        static void Main(string[] args)
        {
            ArrayList alStudent = new ArrayList();
            alStudent.Add(new Student(1,"A"));
            alStudent.Add(new Student(6, "F"));
            alStudent.Add(new Student(3, "C"));
            alStudent.Add(new Student(7, "G"));
            alStudent.Add(new Student(5, "E"));
            alStudent.Add(new Student(2, "B"));
            alStudent.Add(new Student(4, "D"));
            alStudent.Add(new Student(8, "H"));
            alStudent.Add(new Student(8, "H"));


            alStudent.Sort();


             Console.WriteLine("After sorting...");
            ////  alStudent.Reverse();
            foreach (Student s in alStudent)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }

            Console.WriteLine("Enumerations...");
            IEnumerator ae = alStudent.GetEnumerator();
            while (ae.MoveNext())
            {
                Student s = (Student)ae.Current;
                Console.WriteLine(s.Id + " " + s.Name);
            }

            Console.Read();

      }
    }
}
