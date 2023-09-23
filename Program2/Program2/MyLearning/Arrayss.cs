using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{
    class Arrayss
    {
        public static void Array1d()
        {
            int[] ar1 = new int[] { 8, 3, 9, 4, 5 };
            int temp;
            for (int i = 0; i < ar1.Length; i++)
            {
                for (int j = 0; j < ar1.Length - 1; j++)
                {
                    if (ar1[j] > ar1[j + 1])
                    {
                        temp = ar1[j];
                        ar1[j] = ar1[j + 1];
                        ar1[j + 1] = temp;
                    }
                }
            }
            //ar1[0] = 10;
            //ar1[1] = 20;
            //ar1[2] = 30;
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(ar1[i]);
            //}
            foreach (int item in ar1)
            {
                Console.WriteLine(item);
            }
        }
        public static void Array2d()
        {
            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 11, 22, 33 } };

            for (int i = 0; i < 2; i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine(arr1[i,j]+"\t");
                }
                Console.WriteLine();
            }
            
        }public static void ArrayJagged() 
        {
            int[][]arr= new int[3][];
            arr[0]= new int[3] {1,2,3};
            arr[1] = new int[4] { 10, 30, 89, 78 };
            arr[2] = new int[1] { 4 };
            foreach (int[]ar in arr)
            { foreach(int item in ar)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
