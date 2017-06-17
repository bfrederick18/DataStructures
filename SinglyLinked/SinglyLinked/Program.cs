using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinked
{
    class Program
    {
        static void Main(string[] args)
        {

            SinglyLinkedList singlyLinked = new SinglyLinkedList();

            singlyLinked.Add(8);
            singlyLinked.Add(3);
            singlyLinked.Add(6);

            foreach (var item in singlyLinked)
            {
                Console.WriteLine(" {0}",item);
            }
            Console.WriteLine("--------");

            singlyLinked.Insert(9, 2);
            singlyLinked.Insert(17, -1);
            singlyLinked.Insert(16, 0);
            

            foreach(var item in singlyLinked)
            {
                Console.WriteLine(" {0}", item);
            }
            Console.WriteLine("--------");

            singlyLinked.Delete(8);

            foreach (var item in singlyLinked)
            {
                Console.WriteLine(" {0}", item);
            }
            Console.WriteLine("--------");


            Console.ReadKey();

        }
    }
}