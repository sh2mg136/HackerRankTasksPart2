using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasksPart2
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    internal class ElementsOfALinkedList
    {
        public static void printLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.InsertNode(1);
            list.InsertNode(2);
            list.InsertNode(20);
            list.InsertNode(16);

            SinglyLinkedListNode start = list.head;

            while (start.data != head.data)
            {
                start = start.next;
            }

            if (start != null)
            {
                while (start?.next != null)
                {
                    start = start.next;
                    if (start != null)
                    {
                        Console.WriteLine(start.data);
                    }
                }
            }
        }
    }
}