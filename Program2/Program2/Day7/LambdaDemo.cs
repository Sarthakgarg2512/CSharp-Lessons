using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day7
{
    class LambdaDemo
    { 
        public static void DemoA()
        {
            Func<int, int> foo = x => x / 2; // last parameter is result, first one in input in <int,int>
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static void DemoB()
        {
            Func<int> foo = () => 100;//only result parameter
            int result = foo();
            Console.WriteLine(result);
        }
        public static void DemoC()
        {
            Func<double, double, double> callme = (x, y) => (x + y) / 2;
            int v1 = 101;
            int v2 = 10;
            double result = callme(v1, v2);
            Console.WriteLine(result);
            
        }
        public static void DemoD()
        {
            Func<double, double, double, double> runme = (x, y,z) => (x + y) / z;
            int v1 = 101;
            int v2 = 10;
            int v3 = 10;
            double result = runme(v1, v2,v3);
            Console.WriteLine(result);
        }
        public static void DemoE()
        {
            Func<int, double> callme =x=>(double)x/2;// to get output in double i.e. in decimal
            int v1 = 101;
            double result = callme(v1);
            Console.WriteLine(result);
        }
        public static void DemoF()
        {
            Func<double, int> callme = x => (int)x / 2;
            int v1 = 101;
            int result = callme(v1);
            Console.WriteLine(result);
        }
        public static void DemoG()
        {
            Func<double, int> callme = x => (int)x / 2;
            int v1 = 101;
            double result = callme(v1);
            Console.WriteLine(result);
        }
        public static void Echo(Func<string> foo)
        {
            string str = foo();
            Console.WriteLine(str);
        }
        public static void TestEcho()
        {
            Echo(() => "Hello");
            Echo(() => "World");
        }
        public static double DoTrans(Func<int, int, double> foo)
        { 
            return foo(50, 0);
        }
        public static void TestDoTrans()
        {
            Func<int, int, double> Multiply = (x, y) => x * y;
            double d=DoTrans(Multiply);
            Console.WriteLine(d);
            Func<int, int, double> Add = (x, y) => x + y;
            d = DoTrans(Add);
            Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("Invalid");
                };
                
                return 0;
               
            };
            double d1 = DoTrans(Divide);
            Console.WriteLine(d1);
        }
    }
}
