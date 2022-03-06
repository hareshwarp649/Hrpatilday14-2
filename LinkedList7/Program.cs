using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucLinkSeven
{
    internal class Program
    {
        static void Main(string[] args)          
        {

            LinkSeven val = new LinkSeven();
            val.AddLast(56);
            val.AddLast(30);
            val.AddLast(70);
            val.AddAfter(2, 40);
            val.Find(30);

        }
    }
}
