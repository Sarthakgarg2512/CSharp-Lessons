using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day3
{
    internal class StringLessons
    {
        public static void DemoA()
        {
            String firstString = "Hello";
            char[] data = { 'H', 'e', 'l', 'l', 'o' };
            String secondString = new string(data);
            Console.WriteLine(firstString + "" + secondString);
            String thirdString = String.Empty;
            int x = 0;
        }
        public static void DemoB()
        {
            String s1 = "Tom and jerry";
            Console.WriteLine("Length" + s1.Length);
            Char[] data = s1.ToCharArray();
            foreach (char c1 in data)
            {
                Console.WriteLine(c1);
            }
        }
        public static void DemoC()
        {
            String s1 = "Tom and jerry";
            String[] words = s1.Split(' ');
            Console.WriteLine("Word Count" + words.Count());
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
        public static void DemoD()
        {
            String firstString = "Tom and Jerry";
            String stringInUPPER=firstString.ToUpper();
            Console.WriteLine("firstString:" + firstString);
            Console.WriteLine("stringInUPPER:" + stringInUPPER);
            String stringInlower=firstString.ToLower();
            Console.WriteLine("firstString:" + firstString);
            Console.WriteLine("stringInUPPER:" + stringInlower);
        }
        public static void DemoE()
        {
            String secondString = "    abcdef    ";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);
        }
        public static void TestStringEquals()
        {
            String firstString = "Hello";
            String secondString = "Hello";
            String thirdString = "Gavs";



            bool firstResult = (firstString == secondString);
            bool secondResult = (firstString == thirdString);
            Console.WriteLine("firstString==secondString " + firstResult); // true
            Console.WriteLine("firstString==thirdString " + secondResult);// true



            firstResult = (firstString.Equals(secondString));
            secondResult = (firstString.Equals(thirdString));
            Console.WriteLine("firstString.Equals(secondString) " + firstResult); // true
            Console.WriteLine("firstString.Equals(thirdString) " + secondResult); // true       
        }
        public static void TestSubstring()
        {
            String s1 = "It looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length " + s1.Length);
            String s2 = s1.Substring(5);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            String s3 = s1.Substring(5, 10);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }
        public static void ModifyNumberMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            double x = 100;
            for (int i = 1; i < 1000000; i++)
            {
                x += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(x);
        }
        public static void AssignSameStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                // String s2 = "Hello";
                s1 = "Hello";
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
        public static void Reg()
        {
            String name= "Sarthak";
            name = name.ToUpper();
            Console.Write(name.Substring(0,4));
        }
    }


}
