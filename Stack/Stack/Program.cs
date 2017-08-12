using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WindowWidth = 185;
            //Console.WindowHeight = 45;
            //Console.BufferWidth = 185;
            //Console.BufferHeight = 45;

            StackList stack = new StackList();

            stack.Push(6);
            Display(stack);

            stack.Push(8);
            Display(stack);

            stack.Push(10);
            Display(stack);

            stack.Push(12);
            Display(stack);

            stack.Push(14);
            Display(stack);

            stack.Push(16);
            Display(stack);


            stack.Pop();
            Display(stack);

            stack.Pop();
            Display(stack);

            stack.Pops(3, stack);
            Display(stack);

            stack.Peek();
            Display(stack);


            Console.ReadKey();

        }

        static void Display(StackList stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(" {0}", item);
            }
            Console.WriteLine(" Count : {0}", stack.count);
            Console.WriteLine("--------------------------------");
        }
    }
}
