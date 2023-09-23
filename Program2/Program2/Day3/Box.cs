using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day3
{
    internal class Box // Variables initialised
    {
        public int Height;
        public int Length;
        public int Width;



        public Box(int x)// constructor Created
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString() // Print values into given string
        {
            return $"Height:{Height},Length:{Length},Width:{Width}";
        }
    }
    internal class WoodenBox : Box // inheritance
    {
        public int Area;
        public WoodenBox() : base(1) //Constructor
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public WoodenBox(int x) : base(x) //Constructor
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public WoodenBox(int x, int y) : base(x) //Constructor
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public void Move()
        {
            Console.WriteLine("Wooden Box Shifted");
        }
        public override string ToString() // This will override the parents method 
        {
            return "Tom and Jerry";
        }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(100);
            box.Height = 10;
            box.Length = 20;
            box.Width = 5;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
        }
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Length = 200;
            box.Width = 50;

            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area = 300;
            box.Move();
        }
        public static void TestThree()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Length = 200;
            box.Width = 50;

            box.Open();
            box.Close();
            String output = box.ToString();//Tom and jerry
            Console.WriteLine(output);
            //box.Area = 300;
            //box.Move();
        }
        
        }
    }

