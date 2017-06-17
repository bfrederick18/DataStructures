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
        public int count = 0;
        public SinglyLinkedList()
        {
            head = null; 
        }

        public void Add(int thingToStore)
        {
            #region THADdyboi WUZ HEER
            /*
            if (thingToStore != 0)
            {
                goto label;
            }
            return;
        label:*/
            #endregion

            if (head == null)
            {
                head = new SinglyLinkedNode<int>(thingToStore);
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
                        break;
                    }
                    else
                    {
                        tempNode = tempNode.Next;
                    }
                }
            }
        }

        public void Delete(int thingToDelete)
        {
            SinglyLinkedNode<int> tempNode = head;

            if (head.Thing == thingToDelete)
            {
                head = head.Next;
                count--;
            }

            else
            {
                while (true)
                {
                    if (tempNode.Next == null)
                    {
                        Console.WriteLine("Plez... RETINK UR DISKISION\nERROR : Could Not Find {0} In The Singly Linked List", thingToDelete);
                        break;
                    }

                    if (tempNode.Next.Thing == thingToDelete)
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

        public void DeleteAt(int index)
        {
            if (index > count)
            {
                Console.WriteLine("Plez... RETINK UR DISKISION\nERROR : You Tried To Delete At Index {1}", index);
            }

            if (index == -1)
            {
                head = head.Next;
            }

            else
            {
                SinglyLinkedNode<int> tempNode = head;
                for (int i = 0; i < index; i++)
                {
                    if (tempNode.Next == null)
                    { break; }

                    tempNode = tempNode.Next;
                }

                tempNode.DeleteAfter();
                count--;
            }
        }

        public void Insert(int thingToStore, int index)
        {
            if (index > count)
            {
                Console.WriteLine("Plez... RETINK UR DISKISION\nERROR : You Tried To Insert {0} At Index {1}", thingToStore, index);
            }

            else if (index == -1)
            //doblee check with teeessstts
            {
                SinglyLinkedNode<int> tempNode = new SinglyLinkedNode<int>(thingToStore);

                tempNode.Next = head;

                head = tempNode;
                count++;
            }

            else
            {
                SinglyLinkedNode<int> tempNode = head;
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
