using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day2
{
    internal class box
    {
        public static int height;//global and static
        public  int width;//global and not static
        public const String type = "Wooden";
        public int GetHeight()
        { 
            return height; 
        }
    }
     class TestBox
    {
        public static void TestOne()
        {
            
            box.height = 100;
            //box.width = 200;
            box firstBox = new box(); //local
            box secondBox = new box();//local
            firstBox.width = 121;
            secondBox.width = 919;

            Console.WriteLine($"First Box={firstBox.GetHeight()},{firstBox.width}");
            Console.WriteLine($"Second Box={secondBox.GetHeight()},{ secondBox.width}");
            //box.type = "Glass";
            box.height = 5555;
            Console.WriteLine($"Third Box={firstBox.GetHeight()},{firstBox.width}");
            Console.WriteLine($"Thir Box={secondBox.GetHeight()},{secondBox.width}");
        }
    }
}
