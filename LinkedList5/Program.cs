using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucLinkFiv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkListFive val = new LinkListFive();
            val.AddLast(56);
            val.AddLast(30);
            val.AddLast(70);
            val.AddAfter(2, 40);
            int a = val.Length();
            Console.WriteLine(a);
            val.Pop();
        }
    }
}
