using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day7
{
    class ServiceA
    {
        int x = 0;
        public  void DoTaskA()
        {
            Monitor.Enter(this);//monitor used to lock current thred
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTaskA: ");
            Console.WriteLine("Thread ID: " + id);
            //int x = 0;
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("ID = " + id + ": X = " + x + " icount= " + icount);
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                Monitor.Exit(this);//exit used to unlock it
            }
        }
    }
}
