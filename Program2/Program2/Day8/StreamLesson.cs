using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Program2.Day8
{
   class StreamLesson
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("Press a key followed by enter ");
            int x= Console.Read();
            ch = (char)x; // Get a character
            Console.WriteLine("\n "+ x +" Your key is "+ch);

        }
        public static void TestTwo()
        {
            char ch=' ';
            Console.WriteLine("Press a key q to Exit ");
            while(ch != 'q')
            {
                ch = (char)Console.Read();
                Console.WriteLine(" Your key is " + ch);
            }
            
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a sentence");
            string? str=Console.ReadLine();
            Console.Out.WriteLine("You Typed: "+ str);

        }
        public static void TestNullableTypes() 
        {
            int? x = 0;
            x = null;
            if (x.HasValue)
            {
                Console.Out.WriteLine(x.Value);
            }
            else { Console.Out.WriteLine(x.GetValueOrDefault()); }
        }
    }
}
