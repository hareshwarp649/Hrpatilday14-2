using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLinkFour
{
    internal class SingleFour
    {

        public NodeSin head;

        public void Add(int data)
        {
            NodeSin node = new NodeSin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeSin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeSin)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void AddFirst(int data)
        {
            NodeSin node = new NodeSin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeSin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeSin)temp.next;
                }
                node.next = temp;
                head = temp;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void AddLast(int data)
        {
            NodeSin node = new NodeSin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeSin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeSin)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public int Length()
        {
            NodeSin temp;
            int Count = 0;
            temp = this.head;
            while (temp != null)
            {
                Count++;
                temp = (NodeSin)temp.next;
            }
            return Count;
        }

        public void AddAfter(int Ploc, int data)
        {
            NodeSin temp;
            NodeSin p;
            int loc = Ploc, i = 1;
            int leng = this.Length();
            if (loc > leng)
            {
                Console.WriteLine("Invalid Location");
                Console.WriteLine("Current list having ", leng);
            }
            else
            {
                p = this.head;
                while (i < loc)
                {
                    p = (NodeSin)p.next;
                    i++;
                }
                NodeSin node = new NodeSin(data);
                temp = node;
                temp.next = p.next;
                Console.WriteLine("{0} inserted into after {1} linked list", node.data,  p.data);
                p.next = temp;
            }
        }
    }
}
