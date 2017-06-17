using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinked
{
    public class SinglyLinkedNode<T>
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

        public SinglyLinkedNode(T thingToStore, SinglyLinkedNode<T> next = null)
        {
            Thing = thingToStore;
            Next = next;
        }

        public SinglyLinkedNode<T> AddAfter(T thingToStore)
        {
            SinglyLinkedNode<T> node = new SinglyLinkedNode<T>(thingToStore);
            node.Next = Next;
            Next = node;
            return node;
        }

        public void DeleteAfter()
        {
            if (Next != null)
            {
                Next = Next.Next;
            }
        }
    }
}