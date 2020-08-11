using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(2);
            linkedList.AddLast(new LinkedListNode<int>(4));
            linkedList.AddLast(new LinkedListNode<int>(6));
            linkedList.AddLast(linkedList.Find(4));

            CirclularLinkedListValidator circlularLinkedListValidator = new CirclularLinkedListValidator();
            Console.WriteLine(circlularLinkedListValidator.IsCircular<int>(linkedList));
        }
    }
}
