using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLinkFour
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SingleFour four = new SingleFour();
            LinkedList<int> LinkdList = new LinkedList<int>();
            four.AddFirst(5);
            four.AddAfter(0, 30);
        }
    }
}
