using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLinkNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinklistNine val = new LinklistNine();
            val.AddLast(56);
            val.AddLast(30);
            val.AddLast(70);
            val.InsertAfter(30, 40);
            val.remove(70);
        }
    }
}
