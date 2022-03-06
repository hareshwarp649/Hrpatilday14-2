using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucLinkSix
{
    class Program
    {
       public static void Main(string[] args)
        {


            LinkSix num = new LinkSix();
            num.AddLast(56);
            num.AddLast(30);
            num.AddLast(70);
            num.AddAfter(2, 40);
            int a = num.Length();
            Console.WriteLine(a);
            num.Pop();
            num.PopLast();
        }
    }
}
