using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day5
{
    class CollectionDemo
    {

        public static void TestArrayList()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16

            for (int j = 0; j < 10; j++) alist.Add(j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 32



            //for (int i = 0; i < alist.Count; i++)
            //{
            //    Console.Write(alist[i] + ",");
            //    if (i > 0 && i % 10 == 0) Console.WriteLine();

            //foreach (int x in alist)
            //{
            //    Console.Write(x + " ");
            //}
            if (alist is IEnumerable)//does alist impliment IEnumerable
            {
                IEnumerator er = alist.GetEnumerator();
                while (er.MoveNext())
                {
                    object obj = er.Current;
                    if (typeof(int) == obj.GetType())
                    {
                        int x = (int)obj;// unboxing
                        Console.WriteLine(x);
                    }
                    else
                        Console.WriteLine(obj.ToString());
                }

            }
        }
        public static void GenericListInteger()
        {
            List<int> alist = new List<int>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);



            for (int i = 0; i < 10; i++)
                alist.Add(i);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);



            //for (int j = 0; j < 10; j++)
            //    alist.Add("abcd" + j);





            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }
        public static void GenericListString()
        {
            List<string> alist = new List<string>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            for (int j = 0; j < 10; j++)
                alist.Add("abcd" + j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            //for (int i = 0; i < 10; i++)
            //    alist.Add(i);
            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }
        public static void GenericListDemoEmp()
        {
            List<Emp> empList = new List<Emp>();
            Console.WriteLine("\tCapacity " + empList.Capacity);
            Emp e1 = new Emp() { ID = 123, FirstName = "Venkat", Salary = 10000 };
            empList.Add(e1);
            empList.Add(new Emp() { ID = 456, FirstName = "Krishnan", Salary = 15000 });
            //empList.Add("Hello");
            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            empList.Add(new Emp() { ID = 1000, FirstName = "Sam", Salary = 10000 });
            empList.Add(new Emp() { ID = 500, FirstName = "John", Salary = 10000 });
            empList.Add(new Emp() { ID = 200, FirstName = "Suresh", Salary = 10000 });
            empList.Add(e1);
            empList.Add(e1);



            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            IEnumerator data = empList.GetEnumerator();
            while (data.MoveNext())
            {
                Object obj = data.Current;
                if (obj.GetType() == typeof(Emp))
                {
                    Emp e = (Emp)obj;
                    Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.FirstName, e.Salary);
                }
                else
                    Console.WriteLine("=======> Object is not an Employee");
            }
            foreach (Emp e2 in empList)
            {
                Console.WriteLine($"Id={0}, Name={1}, Salary={2} ", e2.ID, e2.FirstName, e2.Salary);
            }
        }
        public static void SetStringDemo()
        {
            HashSet<String> stringSet = new HashSet<String>();
            stringSet.Add("Chennai");
            stringSet.Add("Salem");
            stringSet.Add("Erode");
            stringSet.Add("Tirupur");
            stringSet.Add("Kovai");
            stringSet.Add("Chennai");
            stringSet.Add("Trichy");
            stringSet.Add("Madurai");
            stringSet.Add("Nellai");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            //stringSet.Add(null);
            //stringSet.Add(null);
            Console.WriteLine($"Count:{stringSet.Count}");
            foreach (var item in stringSet)
            {
                if (item != null)
                    Console.WriteLine(item);
                else
                    Console.WriteLine("NULL");
            }
        }
        public static void TestGenericSortedSetInt()
        {
            SortedSet<int> alist = new SortedSet<int>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            alist.Add(10);
            alist.Add(10);
            alist.Add(10);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                alist.Add(x);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (int i in alist)
                Console.Write(i + ",");
        }
        public static void TestGenericSortedSetString()
        {
            SortedSet<string> alist = new SortedSet<string>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            alist.Add("Hello");
            alist.Add("Hello");
            alist.Add("Hello");
            alist.Add("Ashley");
            alist.Add("Gavs");
            alist.Add("Gavs");
            alist.Add("Infy");
            alist.Add("CTS");
            alist.Add("TCS");
            alist.Add("Adyar");
            alist.Add("Banglore");
            alist.Add("Pune");
            alist.Add("Goa");
            alist.Add("Zif");



            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (string i in alist) Console.Write(i + ",");


        }

    }
    

}



    


    

