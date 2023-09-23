using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// int x=100; Illegal
namespace Program2.Day2
{ //int y=200; Illegal
    internal class DemoA
    {
        //Global Variables can be declared here
         int x=29;  //Member variable /Class variable /Field
         static int y = 30;
        public static void FirstMethod()// Ststic method
        {
            //Local Variables
            int y = 2000;
            //console.WriteLine(x); // Non static Member can not be accessed

            Console.WriteLine(y);//Local Variables
            Console.WriteLine(DemoA.y);//Global ststic variables
        }
        int variableA = 0;
        public static void SecondMethod()// Ststic method
        {
            //Local Variables
            int y = 5000;
            //Console.WriteLine(x); // Non static Member can be accessed

            Console.WriteLine(y);//Local Variables
            Console.WriteLine(DemoA.y);//Global ststic variables
        }
    }
    internal class DemoB
    {

    }
}

namespace Program2.Gavs
{
    internal class DemoA
    {
    }
}
