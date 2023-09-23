using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{
     class Hello
    {
    public static void pr()
        {
            //int con = 69;
            //Console.WriteLine(con);
            //object o = con;
            ////int j = (int)o;
            //Console.WriteLine(o);
            Console.WriteLine("Enter your name");
            string name= Console.ReadLine();
            Console.WriteLine("Hello " +name);

            Console.WriteLine("How much amount do you have?");
            string amt= Console.ReadLine();
            Console.WriteLine("You have a total of $ " +(Convert.ToInt32(amt) +4));
        }
 
        
            public static void conversion()
            {
                int i = 1234;
                String b = Convert.ToString(i);
                Console.WriteLine(b);
            
        }
        
    }
}
