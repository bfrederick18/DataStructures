using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackList
    {
        StackNode<int> head;
        public int count = 0;
        public StackList()
        {
            head = null;
        }

        public void Push(int thingToStore)
        {
            if (head == null)
            {
                head = new StackNode<int>(thingToStore);
                count++;
            }
            else
            {
                StackNode<int> tempNode = new StackNode<int>(thingToStore);
                tempNode.Next = head;
                head = tempNode;
                count++;
            }
        }
        public void Pop()
        {
            if (head == null)
            {
                throw new Exception("Head is 'null'");
            }
            else
            {
                head = head.Next;
                count--;
            }
        }
        public void Pops(int howMany, StackList stack)
        {
            if (howMany > count)
            {
                throw new Exception("HowMany is gretaer that the count");
            }
            
            for (int i = 0; i < howMany; i++)
            {
                stack.Pop();
            }
        }
        public void Peek()
        {
            Console.WriteLine(" ~~~~~");
            Console.WriteLine(" | {0} |",head.Thing);
            Console.WriteLine(" ~~~~~");
        }

        public bool IsEmpty()
        {
            if (head == null)
                return true;

            else
                return false;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Thing;
                current = current.Next;
            }
        }
    }
}
