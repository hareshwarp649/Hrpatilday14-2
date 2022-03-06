using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruLinkList
{
     class SingleFirst
    {
        public NodeSinLin head;

        public void Add(int data)
        {
            NodeSinLin node = new NodeSinLin(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                NodeSinLin temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Linked list", node.data);
        }

       
    }
}
