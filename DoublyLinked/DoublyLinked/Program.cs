using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinked
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WindowWidth = 185;
            Console.WindowHeight = 40;
            //Console.BufferWidth = 185;
            Console.BufferHeight = 40;

            DoublyLinkedList doublyLinked = new DoublyLinkedList();

            Welcome();

            doublyLinked.AddToEnd(8);
            doublyLinked.AddToEnd(11);
            doublyLinked.AddToEnd(21);
            doublyLinked.AddToEnd(92);

            Display(doublyLinked);

            doublyLinked.AddToFront(4);
            doublyLinked.AddToFront(2);
            doublyLinked.AddToFront(1);

            Display(doublyLinked);

            doublyLinked.DeleteAtFront();
            doublyLinked.DeleteAtFront();
            doublyLinked.DeleteAtFront();
            doublyLinked.DeleteAtFront();
            doublyLinked.DeleteAtFront();

            Display(doublyLinked);

            doublyLinked.DeleteAtEnd();

            Display(doublyLinked);

            doublyLinked.AddAt(17, -1);
            doublyLinked.AddAt(99, 1);
            doublyLinked.AddAt(30, 1);

            Display(doublyLinked);

            doublyLinked.DeleteAt(1);
            doublyLinked.DeleteAt(1);

            Display(doublyLinked);

            Console.ReadKey();
        }

        static void Display(DoublyLinkedList doublyLinked)
        {
            foreach (var item in doublyLinked)
            {
                Console.WriteLine(" {0}", item);
            }
            Console.WriteLine(" Count : {0}", doublyLinked.count);
            Console.WriteLine("--------------------------------");
        }

        static void Welcome()
        {
            Console.WriteLine("\n  Welcome to DoublyLinkedLists ");
            Console.WriteLine("\n--------------------------------");
        }
    }
}
