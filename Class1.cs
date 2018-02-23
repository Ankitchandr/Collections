using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppcollection
{
    class Class1
    {
        static void Main(string[] args)
        {
            
            ArrayList al = new ArrayList();
            ineligible:
            Console.WriteLine("Operations on Array List");
            Console.WriteLine("");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Add Element");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Clear ");
            Console.WriteLine("4. Insert ");
            Console.WriteLine("5. Remove");
            Console.WriteLine("6. RemoveThroughIndex ");
            Console.WriteLine("7. PresentCapacity ");



            Console.WriteLine(" Enter any options");
            // String i = Console.ReadLine();
            // int i = Convert.ToInt32(Console.ReadLine());

            String input = Console.ReadLine();
            int selectedOption;
            if (int.TryParse(input, out selectedOption))
            {


                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine(" Enter five elements");
                        int[] a = new int[5];
                        for (int j = 0; j < a.Length; j++)
                        {
                            //a[j] = Convert.ToInt32(Console.ReadLine());
                            //al.Add(a[j]);
                            al.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        break;

                    case 3:
                        al.Clear();
                        Console.WriteLine("Array List is clear");
                        break;

                    case 4:

                        if (al.Capacity == 0)
                        {
                            Console.WriteLine("ArrayList is empty chose option 1 first");
                        }
                        else
                        {
                            Console.WriteLine("Enter Index");
                            int index = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter value");
                            int value = Convert.ToInt32(Console.ReadLine());
                            al.Insert(index, value);
                            Console.WriteLine("Successfully inserted...");
                        }
                        break;
                    case 5:
                        if (al.Capacity == 0)
                        {
                            Console.WriteLine("ArrayList is empty chose option 1 first");
                        }

                        else
                        {
                            Console.WriteLine("Enter Removing value");
                            // int val = Convert.ToInt32(Console.ReadLine());
                            al.Remove(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Removing successfully...");
                        }
                        break;


                     case 6:
                        if (al.Capacity == 0)
                        {
                            Console.WriteLine("ArrayList is empty chose option 1 first");
                        }

                        else
                        {
                            Console.WriteLine("Enter index Number");
                            al.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Removing successfully...");
                        }
                        break;
                       

                    case 2:
                        if (al.Capacity == 0)
                        {
                            Console.WriteLine("ArrayList is empty chose option 1 first");
                        }
                        else
                        { 
                            Console.WriteLine("Elements are: ");
                            foreach (var k in al)
                            {
                                Console.Write(k + " ");
                            }

                            Console.Read();
                       }
                        break;


                    case 7:
                         Console.WriteLine("Present Capacity :" + al.Capacity);
                        break;


                    default: Console.WriteLine("Not 10, 20 or 30"); break;
                }
            }
            goto ineligible;

        }
    }
    }

