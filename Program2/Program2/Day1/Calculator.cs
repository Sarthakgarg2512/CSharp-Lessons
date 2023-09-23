using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day1
{
    internal class Calculator
    {
        public static int Add(int n1,int n2)
        {
            return n1+n2;
        }
        public static int Sub(int n1,int n2)
        {
            return n1-n2;
        }
        public static int Multiply(int n1, int n2) 
        {
            return n1*n2;
        }
        public static int Divide(int n1, int n2)
        { 
            return n1/n2;
        }

    }
}
// to run in program file.
//Console.WriteLine(Calculator.Sub(4,2)); 
