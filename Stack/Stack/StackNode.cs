using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackNode<T>
    {
        #region GetSet
        public T Thing
        {
            get;
            set;
        }
        public StackNode<T> Next
        {
            get;
            set;
        }
        public StackNode<T> Previous
        {
            get;
            set;
        }
        #endregion

        public StackNode(T thingToStore, StackNode<T> next = null, StackNode<T> previous = null)
        {
            Thing = thingToStore;
            Next = next;
            Previous = previous;
        }

        public StackNode<T> AddAfter(T thingToStore)
        {
            StackNode<T> node = new StackNode<T>(thingToStore);
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
