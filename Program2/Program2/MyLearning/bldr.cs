using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{
    public class bldr
    {
        public static void Strbldr()
        {

            StringBuilder sb = new StringBuilder("Hello ");
            //StringBuilder sb=("Hello, ");
            sb.Append(" world");
            sb.AppendLine(" This is a new line");
            sb.Append("Bye");
            sb.Insert(6,"beautiful");
            //sb.Remove(0, 6);
            //sb.Replace("world"," universe ");
            //int length = sb.Length;

            string result = sb.ToString();
            Console.WriteLine(result.Length);
            //Console.WriteLine(length);
            Console.ReadLine();
        }
    }
}
