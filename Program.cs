using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLinkTen
{
     class Program
    {

        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        Node newNode(int key)
        {
            return new Node(key);
        }


        void sort()
        {
            Node Ahead = new Node(0), Dhead = new Node(0);


            splitList(Ahead, Dhead);

            Ahead = Ahead.next;
            Dhead = Dhead.next;


            Dhead = reverseList(Dhead);


            head = mergeList(Ahead, Dhead);
        }


        Node reverseList(Node Dhead)
        {
            Node current = Dhead;
            Node prev = null;
            Node next;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            Dhead = prev;
            return Dhead;
        }


        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }


        Node mergeList(Node head1, Node head2)
        {

            if (head1 == null)
                return head2;
            if (head2 == null)
                return head1;

            Node temp = null;
            if (head1.data < head2.data)
            {
                temp = head1;
                head1.next = mergeList(head1.next, head2);
            }
            else
            {
                temp = head2;
                head2.next = mergeList(head1, head2.next);
            }
            return temp;
        }

        void splitList(Node Ahead, Node Dhead)
        {
            Node ascn = Ahead;
            Node dscn = Dhead;
            Node curr = head;



            while (curr != null)
            {

                ascn.next = curr;
                ascn = ascn.next;
                curr = curr.next;

                if (curr != null)
                {
                    dscn.next = curr;
                    dscn = dscn.next;
                    curr = curr.next;
                }
            }

            ascn.next = null;
            dscn.next = null;
        }
        static void Main(string[] args)
        {

            Program val1 = new Program();
            val1.head = val1.newNode(30);
            val1.head.next = val1.newNode(70);
            val1.head.next.next = val1.newNode(56);
            val1.head.next.next.next = val1.newNode(45);

            Console.WriteLine("Given linkedlist");
            val1.printList();

            val1.sort();


            Console.WriteLine("Sorted linkedlist");
            val1.printList();

        }
    }
}
