using System;
using System.Collections.Generic;
using LinkedListLibrary;

namespace LLZip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Demonstrates the solution in the console
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();

            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);

            list3.Head = zipLists(list1, list2);
            Console.WriteLine(list3.ToString());
        }

        /// <summary>
        /// Takes in two linked lists and returns the head node of the two lists zipped together. The first node is always the first node from list 1.
        /// </summary>
        /// <param name="list1">List 1</param>
        /// <param name="list2">List 2</param>
        /// <returns>Zipped List</returns>
        public static Node zipLists(LinkedList list1, LinkedList list2)
        {
            Node newHead = (list1.Head != null) ? list1.Head : list2.Head;
            if (list1.Head != null && list2.Head != null)
            {
                Node current1 = list1.Head;
                Node current2 = list2.Head;
                Node temp1 = current1.Next;
                Node temp2 = current2.Next;
                while (current1 != null && current2 != null)
                {
                    current1.Next = current2;
                    if (temp1 == null && temp2 != null) break;
                    current2.Next = temp1;
                    if (temp2 == null) break;
                    current1 = temp1;
                    current2 = temp2;
                    temp1 = temp1.Next;
                    temp2 = temp2.Next;
                }
            }
            return newHead;
        }
    }
}
