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
        int count = 0;
        public SinglyLinkedList()
        {
            head = null; 
        }

        public void Add(int thingToStore)
        {
            if (head == null)
            {
                head.AddAfter(thingToStore);
                count++;
            }

            else
            {
                SinglyLinkedNode<int> tempNode = head;
                while (true)
                {
                    if (tempNode.Next == null)
                    {
                        tempNode.AddAfter(thingToStore);
                        count++;
                    }
                    else
                    {
                        tempNode = tempNode.Next;
                    }
                }
            }
        }

        public void Insert(int thingToStore, int index)
        {
            if (index > count)
            {
                Console.WriteLine("Plez... RETINK UR DISKISION\nERROR ERROR ERROR");
            }

            if (index == 0)
            //doblee check with teeessstts
            {
                SinglyLinkedNode<int> tempNode = new SinglyLinkedNode<int>(thingToStore);

                tempNode.Next = head;

                head = tempNode;
            }

            else
            {
                SinglyLinkedNode<int> tempNode = head;
                for (int i = 0; i < index; i++)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.AddAfter(thingToStore);
            }
        }


    }
}
