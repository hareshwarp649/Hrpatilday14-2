using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucLinkSix
{
    internal class LinkSix
    {

        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void AddFirst(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                node.next = temp;
                head = temp;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void AddLast(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public int Length()
        {
            Node temp;
            int Count = 0;
            temp = this.head;
            while (temp != null)
            {
                Count++;
                temp = (Node)temp.next;
            }
            return Count;
        }

        public void AddAfter(int Atom, int data)
        {
            Node temp;
            Node p;
            int nuclear = Atom, i = 1;
            int leng = this.Length();
            if (nuclear > leng)
            {
                Console.WriteLine("Invalid Location");
                Console.WriteLine("Current list having ", leng);
            }
            else
            {
                p = this.head;
                while (i < nuclear)
                {
                    p = (Node)p.next;
                    i++;
                }
                Node node = new Node(data);
                temp = node;
                temp.next = p.next;
                Console.WriteLine("{0} inserted into after {1} linked list", node.data, p.data);
                p.next = temp;
            }
        }
        public void Pop()
        {
            Node temp;
            if (this.head == null)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                temp = this.head;
                Console.WriteLine(temp.data);
                head = (Node)head.next;
                temp.next = null;
            }
        }
        public void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                Node secondLast = head;
                Node temp = head;
                while (temp.next != null)
                {
                    secondLast = temp;
                    temp = (Node)temp.next;
                }
                Console.WriteLine(secondLast.data);
                temp.next = null;
            }
        }

    }
}
