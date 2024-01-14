using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((int)'a'); // ascii conversion
            //Console.WriteLine((int)'z');
            //Collection();

            IntArraySorting();
            Console.ReadKey();
        }
        static void stringArraySorting()
        {
            string[] stringArray = { "apple","ana","banana","bbaa"};
            
        }
        static void IntArraySorting()
        {
            int[] intArray = { 7,6,3,5,8};
            //var sortedArray = from a in intArray
            //                  orderby a
            //                  select a;

            //using single for loop
            for(int a=0;a<intArray.Length-1;a++)
            {
                if(intArray[a]>intArray[a+1])
                {
                    int temp = intArray[a];
                    intArray[a] = intArray[a+1];
                    intArray[a + 1] = temp;

                    a =-1;
                }
            }
            Console.WriteLine("sorted array:");
            foreach(int b in intArray)
            {
                Console.WriteLine(b);
            }

        }
        static void Collection()
        {
            int[] arr = {1,3,4,5,6,2 };
            var ar = from a in arr
                     where a%2==1
                     orderby a descending
                     select a;
            foreach(var v in ar)
            {
                Console.WriteLine(v);
            }

            var skipFunction = arr.OrderByDescending(b=>b).SkipWhile(a=>a>4);  //it works on sorted list
            Console.WriteLine("skip function:");
            foreach(var a in skipFunction)
            {
                Console.WriteLine(a);
            }
                     
        }
        static void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            sb.Append("world");
            Console.WriteLine(sb.ToString());
        }
        static void MultiThread()
        {
            Method1();
            Method2();

            //Thread t1 = new Thread(() => Method1());
            //Thread t2 = new Thread(() => Method2());
            //t1.Start();
            //t2.Start();

        }
        static void Method1()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Method-1");
                Thread.Sleep(1000);
            }
        }
        static void Method2()
        {
            for(int j=0;j<5;j++)
            {
                Console.WriteLine("Method-2");
            }
        }
    }

}
