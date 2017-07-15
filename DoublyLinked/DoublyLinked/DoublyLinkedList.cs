using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinked
{
    public class DoublyLinkedList
    {
        DoublyLinkedNode<int> head;
        public int count = 0;
        public DoublyLinkedList()
        {
            head = null;
        }

        public void AddToEnd(int thingToStore)
        {
            if (head == null)
            {
                head = new DoublyLinkedNode<int>(thingToStore);
                count++;
            }

            else
            {
                DoublyLinkedNode<int> tempNode = head;
                while (true)
                {
                    if (tempNode.Next == null)
                    {
                        tempNode.AddAfter(thingToStore);
                        count++;
                        break;
                    }

                    else
                    {
                        tempNode = tempNode.Next;
                    }
                }
            }
        }
        public void AddToFront(int thingToStore)
        {
            if (head == null)
            {
                head = new DoublyLinkedNode<int>(thingToStore);
                count++;
            }

            else
            {
                DoublyLinkedNode<int> node = new DoublyLinkedNode<int>(thingToStore, null, head);
                head = node;
                count++;
            }
        }
        public void AddAt(int thingToStore, int index)
        {
            if (index > count)
            {
                Console.WriteLine("Plez... RETINK UR DISKISION\nERROR : You Tried To Insert {0} At Index {1}", thingToStore, index);
            }

            else if (index == -1)
            //doblee check with teeessstts
            {
                DoublyLinkedNode<int> tempNode = new DoublyLinkedNode<int>(thingToStore);

                tempNode.Next = head;

                head = tempNode;
                count++;
            }

            else
            {
                DoublyLinkedNode<int> tempNode = head;
                for (int i = 0; i < index; i++)
                {
                    if (tempNode.Next == null)
                    { break; }

                    tempNode = tempNode.Next;
                }

                tempNode.AddAfter(thingToStore);
                count++;
            }
        }

        public void DeleteAtEnd()
        {
            if (head == null)
            {
                Console.WriteLine("Plez... RETINK UR DISKISION\nERROR : Could Not Delete Head Since It Is Null");
            }

            else
            {
                DoublyLinkedNode<int> tempNode = head;
                while (true)
                {
                    if (tempNode.Next.Next == null)
                    {
                        tempNode.DeleteAfter();
                        count--;
                        break;
                    }

                    else
                    {
                        tempNode = tempNode.Next;
                    }
                }
            }
        }
        public void DeleteAtFront()
        {
            if (head == null)
            {
                Console.WriteLine("Plez... RETINK UR DISKISION\nERROR : Could Not Delete Head Since It Is Null");
            }

            else
            {
                head = head.Next;
                count--;
            }
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
