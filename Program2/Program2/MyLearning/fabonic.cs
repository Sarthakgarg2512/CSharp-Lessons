using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{

    class Fab
    {
        public static void Fabonic()
        {
            Console.WriteLine("Enter the number of Fibonacci numbers to generate: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
