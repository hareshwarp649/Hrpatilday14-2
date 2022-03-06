using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLinSec
{
    internal class SingleSecon
    {

        public NodeSecLin head;

        public void Add(int data)
        {
            NodeSecLin node = new NodeSecLin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeSecLin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeSecLin)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", arg0: node.data);
        }

        public void AddFirst(int data)
        {
            NodeSecLin node = new NodeSecLin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeSecLin temp = head;
                while (temp.next != null)
                {
                    temp = (NodeSecLin)temp.next;
                }
                node.next = temp;
                head = temp;
            }
            Console.WriteLine("{0} inserted into linked list", arg0: node.data);
        }
    }
}
