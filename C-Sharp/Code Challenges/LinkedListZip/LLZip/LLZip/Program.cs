using System;
using System.Collections.Generic;
using LinkedListLibrary;

namespace LLZip
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

        public static Node zipLists(LinkedList list1, LinkedList list2)
        {
            Node newHead = (list1.Head != null) ? list1.Head : list2.Head;
            Node current1 = list1.Head;
            Node current2 = list2.Head;
            Node temp1 = current1.Next;
            Node temp2 = current2.Next;
            //bool break1 = false;
            //bool break2 = false;
            while (current1 != null && current2 != null)
            {
                current1.Next = current2;
                current2.Next = temp1;
                current1 = temp1;
                current2 = temp2;
                if (temp1 == null) break;
                temp1 = temp1.Next;
                if (temp2 == null) break;
                temp2 = temp2.Next;
            }
            return newHead;
        }
    }
}
