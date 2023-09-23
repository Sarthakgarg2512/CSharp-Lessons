using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day5
{
    internal class Demos
    {
        public static void D()
        {
            int v1 = 1000;
            Console.WriteLine($"v1:{v1}");
            refer.DoTask(v1);
            Console.WriteLine($"v1:{v1}");
            refer.DoTaskA(ref v1);
            Console.WriteLine($"v1:{v1}");

        }
    }
}
