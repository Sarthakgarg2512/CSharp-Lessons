using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day7
{
    class ThreadDemo
    {
        public static void DemoCurrentThread()
        {
            Thread t1= Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadId="+id);
            Console.WriteLine("Is Alive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("Current Culture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());//Indian region
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());//French region
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());//Dutch Region
        }

        public static void DemoA()
        {
            Thread t=Thread.CurrentThread;
            int id=t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID: " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            t1.Start();
            a1.DoTaskA();// Local variables are thread safe bydefault
            Console.WriteLine("-----------------End Of DemoB--------------------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID: " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            Console.WriteLine(t1.ManagedThreadId+" T1 State " +t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + " State After Start " + t1.ThreadState);
            Thread.Sleep(7000);
            Console.WriteLine(t1.ManagedThreadId + " T1 State After Sleep " + t1.ThreadState);
            Console.WriteLine("-----------------End Of DemoB--------------------");
        }
        public static void DemoC() 
        {
            Thread t=Thread.CurrentThread;
            int id=t.ManagedThreadId;
            Console.WriteLine("MainTh ID:" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2=new Thread(ts);
            //Thread t3=new Thread(ts);
            t1.Start();
            t2.Start();
            //t3.Start();
            t1.Join(7000);
            //if(t1.IsAlive) t1.Abort(); 
            t2.Join(2000);
            //if (t2.IsAlive) t2.Abort();

            Console.WriteLine("---------------------End----------------------");
        }
    }
}
