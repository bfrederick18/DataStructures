using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinked
{
    class SinglyLinkedNode<T>
    {
        #region GetSet
        public T Thing
        {
            get;
            set;
        }
        public SinglyLinkedNode<T> Next
        {
            get;
            set;
        }
        #endregion

        private SinglyLinkedNode(T thingToStore, SinglyLinkedNode<T> next = null)
        {
            Thing = thingToStore;
            Next = next;
        }
        public SinglyLinkedNode<T> AddAfter(T thingToStore)
        {
            SinglyLinkedNode<T> node = new SinglyLinkedNode<T>(thingToStore);

            Next = node;

            return node;
        }

        public bool CanDeleteAfter()
        {
            SinglyLinkedNode<T> node = Next;
            if (node.Next.Next != null)
            {
                return false;
            }
            else return true;
        }

        public SinglyLinkedNode<T> DeleteAfter()
        {
            SinglyLinkedNode<T> node = Next;

            if (CanDeleteAfter())
            {
                node = node.Next.Next;
                node.Next = null;

                return node;
            }

            else
            {
                node.Next = null;
                return node;
            }
        }
    }
}