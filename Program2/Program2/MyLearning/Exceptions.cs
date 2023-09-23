using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Program2.MyLearning
{
    internal class Exceptions
    {
        public static void ExceptionDem()
        {
            Console.WriteLine("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;
                Console.WriteLine("The Result is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide number by 0");
                //Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Remaining 1");
            }
            Console.ReadLine();
            //Console.WriteLine("Remaining 2");
            //Console.WriteLine("Remaining 3");
        }
        public static void ExceptionDem2()
        {

            try
            {
                Console.WriteLine("Enter a String");
                String name = Console.ReadLine();
                
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("String is null..");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
