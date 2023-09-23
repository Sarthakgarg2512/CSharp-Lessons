using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day3
{
    internal class Sorting
    {
        public static void SortingStrings()
        {
            //sort the names
            String[] names = new String[5];
            names[0] = "Xavier";
            names[1] = "Basker";
            names[2] = "Anandh";
            names[3] = "John";
            names[4] = "anandh";
            //String temp;
            String temp = String.Empty;
            int len = names.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < (len - 1); j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(names[i] + ",");

            }
        }

        public class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a shape.");
            }
            public class Circle : Shape
            {
                public override void Draw()
                {
                    Console.WriteLine("Drawing a circle.");
                }
                Shape shape = new Circle();
                 // Output: "Drawing a circle."

            }

        }


    }

}

    

