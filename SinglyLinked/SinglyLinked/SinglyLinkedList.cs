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
            #region THAD WUZ HERE
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
            }

            else
            {
                while (true)
                {
                    if (tempNode.Next == null)
                    {
                        Console.WriteLine("ERROR : COULD NOT FIND {0} IN THE SINGLY LINKED LIST", thingToDelete);
                        break;
                    }

                    if (tempNode.Next.Thing == thingToDelete)
                    {
                        tempNode.DeleteAfter();
                        break;
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

            if (index == -1)
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
