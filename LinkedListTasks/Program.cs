using LinkedListTasks;
using System.Diagnostics;

//
//
// Insert a Node at the Tail of a Linked List
// https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list/problem?isFullScreen=true
Console.WriteLine("Insert a Node at the Tail of a Linked List");

SinglyLinkedList llist = new SinglyLinkedList();

for (int i = 0; i < 3; i++)
{
    int llistItem = i * 2 + 1;

    SinglyLinkedListNode llist_head = LinkedListSolution.insertNodeAtHead(llist.head, llistItem);
    // SinglyLinkedListNode llist_head = LinkedListSolution.insertNodeAtTail(llist.head, llistItem);

    llist.head = llist_head;
}

LinkedListSolution.PrintSinglyLinkedList(llist.head, "\n", Console.Out);


