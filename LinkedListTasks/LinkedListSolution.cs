namespace LinkedListTasks
{
    internal class LinkedListSolution
    {
        internal static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            var tmp = head;
            if (head == null)
                return new SinglyLinkedListNode(data);

            while (tmp.next != null)
                tmp = tmp.next;
            tmp.next = new SinglyLinkedListNode(data);
            return head;
        }


        internal static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            if (llist == null)
                return new SinglyLinkedListNode(data);

            var cur = llist;
            llist = new SinglyLinkedListNode(data);
            llist.next = cur;

            return llist;
        }


        internal static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);
                node = node.next;
                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }
    }

    internal class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    internal class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }
    }
}