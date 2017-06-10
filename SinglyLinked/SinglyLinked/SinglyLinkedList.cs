using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinked
{
    public class SinglyLinkedList
    {
        SinglyLinkedNode<int> head;
        public SinglyLinkedList()
        {
            head = null; 
        }

        public void Add(int thingToStore)
        {
            if (head == null)
            {
                head.AddAfter(thingToStore);
            }

            else
            {
                SinglyLinkedNode<int> tempNode = head;
                while (true)
                {
                    if (tempNode.Next == null)
                    {
                        tempNode.AddAfter(thingToStore);
                    }
                    else
                    {
                        tempNode = tempNode.Next;
                    }
                }
            }
        }
    }
}
