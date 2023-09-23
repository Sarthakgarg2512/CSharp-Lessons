using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{
    class ConstructorTwo
    {
        public ConstructorTwo()
        {
            Console.WriteLine("First Constructor");

        }
        public ConstructorTwo(int a, int b)
        {
            Console.WriteLine("This is second Constructor "+ (a + b));
        }
        public ConstructorTwo(int a, int b, int c)
        {
            Console.WriteLine("This is third Constructor " + (a + b + c));
        } 
        public ConstructorTwo(string a, string b, string c)
        {
            Console.WriteLine("This is fourth Constructor " + (a + b + c));
        }
        public static void Run()
        {
            ConstructorTwo c=new ConstructorTwo("A","B","C");
        }
        
    }
}
