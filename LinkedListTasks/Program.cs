using LinkedListTasks;
using System.Diagnostics;


//
//
//
// Given a pointer to the head of a linked list and a specific position, determine the data value at that position.
// Count backwards from the tail node. The tail is at postion 0, its parent is at 1 and so on.
Console.WriteLine("Get Node Value");
SinglyLinkedList llist = new SinglyLinkedList();

var list = new List<int> { 1, 4, 4, 3, 2, 1 };
foreach (int i in list) llist.InsertNode(i);
int position = 2;
int iRes = LinkedListSolution.getNode(llist.head, position);
Debug.Assert(iRes == 3);

list = new List<int> { 1, 1, 3, 3, 2, 1 };
foreach (int i in list) llist.InsertNode(i);
position = 0;
iRes = LinkedListSolution.getNode(llist.head, position);
Debug.Assert(iRes == 1);

list = new List<int> { 3, 2, 1 };
foreach (int i in list) llist.InsertNode(i);
position = 2;
iRes = LinkedListSolution.getNode(llist.head, position);
Debug.Assert(iRes == 3);


//
//
// Insert a Node at the Tail of a Linked List
// https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list/problem?isFullScreen=true
Console.WriteLine("Insert a Node at the Tail of a Linked List");

llist = new SinglyLinkedList();

for (int i = 0; i < 3; i++)
{
    int llistItem = i * 2 + 1;

    SinglyLinkedListNode llist_head = LinkedListSolution.insertNodeAtHead(llist.head, llistItem);
    // SinglyLinkedListNode llist_head = LinkedListSolution.insertNodeAtTail(llist.head, llistItem);

    llist.head = llist_head;
}

LinkedListSolution.PrintSinglyLinkedList(llist.head, "\n", Console.Out);


