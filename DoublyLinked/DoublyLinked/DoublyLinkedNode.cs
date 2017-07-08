using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinked
{
    public class DoublyLinkedNode<T>
    {
        #region GetSet
        public T Thing
        {
            get;
            set;
        }
        public DoublyLinkedNode<T> Previous
        {
            get;
            set;
        }
        public DoublyLinkedNode<T> Next
        {
            get;
            set;
        }
        #endregion

        public DoublyLinkedNode(T thingToStore, DoublyLinkedNode<T> previous = null, DoublyLinkedNode<T> next = null)
        {
            Thing = thingToStore;
            Previous = previous;
            Next = next;
        }

        public DoublyLinkedNode<T> AddAfter(T thingToStore)
        {
            DoublyLinkedNode<T> node = new DoublyLinkedNode<T>(thingToStore);
            node.Next = Next;
            Next = node;
            return node;
        }

        public DoublyLinkedNode<T> AddPrevious(T thingToStore)
        {
            DoublyLinkedNode<T> node = new DoublyLinkedNode<T>(thingToStore);
            node.Previous = Previous;
            Previous = node;
            return node;
        }

        public void DeleteAfter()
        {
            if (Next != null)
            {
                Next = Next.Next;
            }
        }

        public void DeletePrevious()
        {
            if (Previous != null)
            {
                Previous = Previous.Previous;
            }
        }
    }
}