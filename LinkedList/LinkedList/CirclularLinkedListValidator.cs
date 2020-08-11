using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class CirclularLinkedListValidator
    {
        public bool IsCircular<T>(LinkedList<T> linkedList)
        {
            LinkedListNode<T> first = linkedList.First;

            if(first == null)
            {
                return false;
            }

            LinkedListNode<T> last = linkedList.First;
             while(first != null || last != null)
            {
                first = first.Next;
                if(last.Next == null)
                {
                    return false;
                }
                else
                {
                    last = last.Next.Next;
                }

                if(first == last)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
