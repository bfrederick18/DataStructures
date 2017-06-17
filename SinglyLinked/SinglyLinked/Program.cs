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

            //Console.WindowWidth = 185;
            Console.WindowHeight = 40;
            //Console.BufferWidth = 185;
            Console.BufferHeight = 40;

            SinglyLinkedList singlyLinked = new SinglyLinkedList();

            singlyLinked.Add(8);
            singlyLinked.Add(3);
            singlyLinked.Add(6);

            Display(singlyLinked);

            singlyLinked.Insert(9, 2);
            singlyLinked.Insert(17, -1);
            singlyLinked.Insert(16, 0);
            singlyLinked.Insert(99, 10);
            singlyLinked.Insert(98, 6);

            Display(singlyLinked);

            singlyLinked.Delete(8);
            singlyLinked.Delete(2);

            Display(singlyLinked);

            singlyLinked.DeleteAt(-1);
            singlyLinked.DeleteAt(2);
            singlyLinked.DeleteAt(3);

            Display(singlyLinked);

            Console.ReadKey();

        }

        static void Display(SinglyLinkedList singlyLinked)
        {
            foreach (var item in singlyLinked)
            {
                Console.WriteLine(" {0}", item);
            }
            Console.WriteLine(" Count : {0}", singlyLinked.count);
            Console.WriteLine("--------------------------------");
        }
    }
}