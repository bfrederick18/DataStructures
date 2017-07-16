using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackList
    {
        StackNode<int> head;
        public int count = 0;
        public StackList()
        {
            head = null;
        }

        public void AddAfter(int thingToStore)
        {
            if (head == null)
            {
                head = new StackNode<int>(thingToStore);
                count++;
            }

            else
            {
                StackNode<int> tempNode = head;
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
        public void AddBefore(int thingToStore)
        {
            if (head == null)
            {
                head = new StackNode<int>(thingToStore);
                count++;
            }

            StackNode<int> tempNode = new StackNode<int>(thingToStore);

            tempNode.Next = head;

            head = tempNode;
            count++;
        }


    }
}
