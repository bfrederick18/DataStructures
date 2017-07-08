﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinked
{
    public class DoublyLinkedList
    {
        DoublyLinkedNode<int> head;
        int count = 0;
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
            }

            else
            {
                DoublyLinkedNode<int> node = new DoublyLinkedNode<int>(thingToStore, null, head);
                head = node;
                count++;
            }
        }
    }
}