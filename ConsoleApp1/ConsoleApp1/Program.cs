using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> arr = new List<int>() { 1,2,3,4,5};
            //    arr.Sort();
            //    int sum_t = 0;
            //    foreach (int i in arr)
            //    {
            //        sum_t = sum_t + i;
            //    }
            //    int sum_min = sum_t - arr[arr.Count - 1];
            //    int sum_max = sum_t - arr[0];
            //Console.WriteLine(sum_max);
            //Console.WriteLine(sum_min);
            //Console.WriteLine(arr);
            //    string ans = sum_min.ToString() + " " + sum_max.ToString();
            //    Console.WriteLine(ans);

            //--------------------------------------------------------------------
            //List<int> arr = new List<int>() { 1,4,4,4,5,3};
            //List<int> ar2 = arr.Distinct().ToList();
            //int mx = 0;
            //foreach (int i in ar2)
            //{
            //    int count = 0;
            //    foreach (int j in arr)
            //    {
            //        if (i == j)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count > mx)
            //    {
            //        mx = count;
            //    }
            //}
            //Console.WriteLine(mx); 

            //-----------------------------------------------------------------------------
            //List<int> lst = new List<int>() { 3,5,6,2,9,7};
            //Console.WriteLine("Before sorting:");
            //foreach (int i in lst)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i=0;i<lst.Count;i++)
            //{
            //    int temp = 0;
            //    for(int j=i+1;j<lst.Count;j++)
            //    {
            //        if(lst[j]<lst[i])
            //        {
            //            temp = lst[i];
            //            lst[i] = lst[j];
            //            lst[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("After Sorting:");
            //foreach (int i in lst)
            //{
            //    Console.WriteLine(i);
            //}

            //----------------------------------------------------------------------------------
            //string s = ", subhash chandra ,";
            ////string[] sa = s.Split(' ');
            ////foreach(string i in sa)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //Console.WriteLine("Before trim:"+s+" is "+s.Length);
            //s = s.TrimStart(',');
            //s = s.TrimEnd(',');
            //s=s.Trim(' ');

            //Console.WriteLine("After trim:"+s+" is "+s.Length);

            //------------------------------------------------------------------------------------
            //Console.WriteLine("Enter the string to check if it is polindrome:");
            //string s = Console.ReadLine();

            //int n = s.Length / 2;
            //bool flag = true;
            //for(int i=0;i<n;i++)
            //{
            //    if(s[i]!=s[s.Length-1-i])
            //    {
            //        flag = false;
            //    }
            //}
            //if(flag==true)
            //{
            //    Console.WriteLine(s+" is a polindrome.");
            //}
            //else
            //{
            //    Console.WriteLine(s+" is not a plonidrome.");
            //}

            //----------------------------------------------------------------------------------
            //string s = "123456789";
            //char[] ca = s.ToCharArray();
            //foreach(char c in ca)
            //{
            //    Console.WriteLine(c);
            //}

            //for(int i=0;i<s.Length/2;i++)
            //{
            //    char temp;
            //    temp = ca[i];
            //    ca[i] = ca[s.Length - 1 - i];
            //    ca[s.Length - 1 - i] = temp;
            //}
            //Console.WriteLine("after reverse:");
            //foreach (char c in ca)
            //{
            //    Console.WriteLine(c);
            //}
            //string s2 = new string(ca);
            //Console.WriteLine(s2);
            //Console.WriteLine(s2.Length);
            //---------------------------------------------------------------------------------

            //int[] ar = new int[] {1,4,5,3,2,5,6,1,4,6,7 };

            //IEnumerable<int> ar2=ar.Distinct();
            //IEnumerable<int> ar3 =ar2.OrderBy(x=>x);
            //IEnumerable<int> ar4 = ar2.OrderByDescending(x=>x);

            //foreach(int i in ar4)
            //{
            //    Console.WriteLine(i);
            //}

            //------------------------------------------------------------------

            //List<int> lst = new List<int>() { 90,80,85,60,90,60,80,90,60};

            //var num = lst.Distinct().OrderBy(x=>x);

            //Dictionary<int, int> d = new Dictionary<int, int>();


            //foreach(var item in num)
            //{
            //    d.Add(item,lst.Count(m=>m==item));
            //    Console.WriteLine(item);
            //}

            //foreach(KeyValuePair<int,int>x in d)
            //{
            //    Console.WriteLine(x.Key+" count is "+x.Value);
            //}


            //-------------------------------------------------------------------------

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread td1 = new Thread(CountDown);
            Thread td2 = new Thread(CountUp);

            td1.Start();
            td2.Start();
            Console.WriteLine(mainThread.Name+" is complete!");

            Console.ReadKey();
        }
        public static void CountDown()
        {
            for(int i=10;i>=0;i--)
            {
                Console.WriteLine("Timer #1:"+i+" seconds.");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("Timer #2:" + i + " seconds.");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}
