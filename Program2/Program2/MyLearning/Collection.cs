using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{
   public class Collection
    {
        public static void Col()
        {
            ArrayList Mylist = new ArrayList();
            Mylist.Add(10);
            Mylist.Add("Sarthak");
            Mylist.Add(10.45);
            //Console.WriteLine(Mylist.Capacity );
            foreach (object obj in Mylist)
                {
                    Console.WriteLine(Mylist);
                }
        }
    }
}
