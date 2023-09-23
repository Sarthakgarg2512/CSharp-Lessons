using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program2.MyLearning
{
    internal class Operators
    {
        static void Greet()
        {
            Console.WriteLine("mrng");
        }
        static float Avg(int x, int y, int z)
        {
            float sum = x + y + z;
            return sum / 3;
        }
        public static void Arth() 
        {
            int a = 2;
            int b=3;
            Console.WriteLine("The Value of a+b is" + (a + b));
            Console.WriteLine("The Value of a-b is" + (a - b));
            Console.WriteLine("The Value of a*b is" + (a * b));
            Console.WriteLine("The Value of a/b is" + (a / b));

        }
        public static void Asg()
        {
            int a = 10;
            int b = a;
            b += 2;
            b -= 4;
            Console.WriteLine(b);
        }
        public static void Logs()
        {
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(!true);
            Console.WriteLine(!false);
        }
        public static void comp()
        {
            Console.WriteLine(350 <= 500);
            Console.WriteLine(350 >= 500);
            Console.WriteLine(350 != 500);
            Console.WriteLine(350 == 500);
        }
        public static void math()
        {
            double a = Math.Sqrt(49);
            Console.WriteLine(a);
            double b= Math.Abs(+47);
            Console.WriteLine(b);
        }
        public static void str()
        {
            string hello = "Hello ji, Kya haal";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello + "Sb thik?");
            Console.WriteLine(string.Concat(hello, "Sb Thik?"));
        }
        public static void strplay()
        {
            Console.WriteLine("What is Your name?");
            string name=Console.ReadLine();
            Console.WriteLine("How much candies you want?");
            string candies=Console.ReadLine();
            Console.WriteLine($"Your name is {name}. You will get {candies} candies");
        }
        public static void indx()
        {
            string hey = "Hello Everyone";
            Console.WriteLine(hey[1]);
            Console.WriteLine(hey.IndexOf("H"));
            Console.WriteLine(hey.Substring(5));
        }
        public static void drive() 
        {
            string ageStr = Console.ReadLine();
            //int age = 17;
            int age=Convert.ToInt32(ageStr);
            if (age <= 18)
            {
                Console.WriteLine("Cant Drive");
            }
            else
            {
                Console.WriteLine("Can Drive");
            }
        }
        public static void loops()
        {
            int i = 0;
            while (i < 500)
            {
                Console.WriteLine(i);
                i++;
            }

        }
        public static void doWhl()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i + 1); i++;
            }while(i < 5);
        }
        public static void forlp()
        {
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
       public static void Greet1()
        {
            //Console.WriteLine("Good Morning");
            Greet();
            Console.WriteLine(Avg(1, 6, 7));
       }
        public static void build()
        {
            string str = "Sarthak";
            str = str + "Garg";
            StringBuilder st = new StringBuilder(str);
            st.Append("Ishu");
            Console.WriteLine(str);
            Console.WriteLine(st);
        }
    }
    
}
