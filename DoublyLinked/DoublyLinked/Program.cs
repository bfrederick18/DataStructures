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
    }
}
