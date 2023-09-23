﻿using Program2.Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day4
{
    internal class ExceptionDemo4
    {
        public static void NestedTryDemo()
        {
            int x = 0; int y = 0; int z = 0;
            Calculator c1 = null;
            Console.WriteLine("Before Try1");
            try
            {
                Console.WriteLine("Inside Try1");
                try
                {
                    Console.WriteLine("\tInside Nested Try");
                    Console.WriteLine("\tEnter a no");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("\tEnter a no");
                    y = int.Parse(Console.ReadLine());
                    c1 = new Calculator();
                    z = c1.Divide(x, y);
                }
                catch (FormatException err)
                {
                    Console.WriteLine("\tInside NestedCatch " + err.Message);
                    //throw err;//re throw
                    throw new Exception("Test msg");
                }
                finally
                {
                    Console.WriteLine("\tInside Nested  ly");
                }
                Console.WriteLine("Inside outer Try1 After Nested  ly");
                Console.WriteLine("Result " + z);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine("Inside outer Catch1 " + err.Message);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Inside outer Catch2 " + err.Message);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Inside outer Catch3 " + err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("Inside outer Catch4 " + err.Message);
            }
            finally
            {
                Console.WriteLine("Inside outer  ly1");
            }
            Console.WriteLine("After outer  ly1");
        }
        class Calculator
        {
            public int Divide(int x, int y)
            {
                return x / y;
            }
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }

            public int DivideA(int x, int y)
            {
                //if (y == 0)
                //    throw new ZeroValueException();
                //if (y == 0)
                //    throw new ZeroValueException("ERROR!!! Value for Y is " + y);
                return x / y;
            }
        }
    }
}
