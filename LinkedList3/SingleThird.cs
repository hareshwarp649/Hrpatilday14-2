using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLinKThree
{
    internal class SingleThird
    {


        public NodeThirLin head;

        public void Add(int data)
        {
            NodeThirLin node = new NodeThirLin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeThirLin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeThirLin)temp.next;
                }
                temp.next = node;
            }

          Console.WriteLine("{0} inserted into linked list",   node.data);
        }

        private static NodeThirLin GetNext(NodeThirLin temp)
        {
            return (NodeThirLin)temp.next;
        }

        public void AddFirst(int data)
        {
            NodeThirLin node = new NodeThirLin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeThirLin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeThirLin)temp.next;
                }
                node.next = temp;
                head = temp;
            }
            Console.WriteLine("{0} inserted into linked list",  node.data);
        }
        public void AddLast(int data)
        {
            NodeThirLin node = new NodeThirLin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeThirLin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeThirLin)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", arg0:  node.data);
        }
    }
}
