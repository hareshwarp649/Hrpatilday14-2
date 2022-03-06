using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLinkEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkListEight value = new LinkListEight();
            value.AddLast(56);
            value.AddLast(30);
            value.AddLast(70);
            value.InsertAfter(56, 40);

        }
    }
}
