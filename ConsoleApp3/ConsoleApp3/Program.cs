using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "subhash goud";

            // Linq();
            // stringBuilder();
            // linq_joins();
            method7();
            Console.ReadKey();
        }
        static void linq_joins()
        {

            //int[] A = { 1,4,7,3,9,8};
            //Console.WriteLine("order by descending: ");
            //var filter = from a in A
            //             where a < 9
            //             orderby a descending
            //             select a;
            //foreach(int a in filter)
            //{
            //    Console.WriteLine(a);
            //}
            List<int> B =new List<int> { 1, 4, 7, 3, 9, 8 };
            Console.WriteLine("Skip function:");
            List<int> ls = B.SkipWhile(x=>x<5).ToList();

            foreach(int a in ls)
            {
                Console.WriteLine(a);
            }
        }
        
        static void Array_Functions()
        {
            int[] arr = new int[] { 4, 6, 2, 3, 8, 9 };
            arr.OrderBy(x => x);
            var v = arr.Skip(2).Take(2);
            foreach (int i in arr.Skip(2).Take(2))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("min and max values:\n");
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
        }
        static void Linq()
        {
            Console.WriteLine("Linq queries:");
            List<int> nums = new List<int>() { 1,3,3,4,5,6,7};
            IEnumerable<int> evenNum = nums.Where(n=>n%2==0);

            var even_var = nums.Where(a=>a%2==0);
            //List<int> even_list = nums.Where<int>(a=>a%2==0);

            List<int> evenNums = nums.FindAll(n=>n%2==0);
            var even_1 = nums.FindAll(a=>a%2==0);
            int even_num = nums.Find(a=>a%2==0);


            int ab = nums.Find(x=>x%2==0);
       

            foreach(int a in even_var)
            {
                Console.WriteLine(a);
            }

           // Console.WriteLine("Find function "+ab);
        }
        static void stringBuilder()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("subhash");
            sb.Append('m');
            sb.Append(535);
            sb.Replace('m','@');
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.Length);

        }
        static void method9()
        {
            string fileloc = @"C:\Users\msubh\Source\Repos\NewRepo\ConsoleApp3\ConsoleApp3\NewFolder\input.txt";

            IEnumerable<string> lines = File.ReadLines(fileloc);
            int counter = 0;
            int sum_bytes = 0;
            foreach(string line in lines)
            {
                string[] sa = line.Split(' ');
                int n = Convert.ToInt32(sa[sa.Length-1]);
                if(n>5000)
                {
                    counter++;
                    sum_bytes = sum_bytes + n;
                }
                Console.WriteLine(line+" "+n );
            }
            Console.WriteLine(counter+" "+sum_bytes);
            string path = @"C:\\Users\\msubh\\Source\\Repos\\NewRepo\\ConsoleApp3\\ConsoleApp3\\NewFolder\\output.txt";

           // string path = @"C:\temp\readme.txt";
            string contents = counter+"\n"+ sum_bytes;

            File.WriteAllText(path, contents);

        }
        static void method8()
        {
            string s = "abcabcbb";
            List<string> lst = new List<string>();
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }

        }

        static void method7()
        {
            string s = "()[()](()){}";

            Dictionary<char, char> d = new Dictionary<char, char>();
            d.Add('(',')');
            d.Add('{','}');
            d.Add('[',']');

            Stack<char> st = new Stack<char>();

            foreach(char c in s)
            {
                if(c=='(' || c=='{' || c=='[')
                {
                    st.Push(c);
                }
                if (c == ')' || c == '}' || c == ']')
                {
                    if ( st.Count>0 && c == d[st.Peek()])
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(c);
                    }
                }

            }
            if(st.Count==0)
            {
                Console.WriteLine("expression is balanced");
            }
            else
            {
                Console.WriteLine("expression is not balanced");
            }

        }
        static void method6()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(3);
            hs.Add(4);
            hs.Add(3);
            hs.Add(4);
            hs.Add(5);

            Console.WriteLine("unique elements in the hashset:");
            foreach(int i in hs)
            {
                Console.WriteLine(i);
            }
        }
        static void method5()
        {
            string[] sa = new string[] {
            "A penny saved is a penny earned.",
            "The early bird catches the worm.",
            "The pen is mightier than the sword."
            };
           
            var qry = from s in sa
                      let words = s.Split(' ')
                      from word in words
                      let w = word.ToLower()
                      where w[0] == 'a' || w[0] == 'e' || w[0] == 'i' || w[0] == 'o' || w[0] == 'u'
                      select w;
            
            foreach (string s in qry)
            {
                Console.WriteLine(s);
            }
            var p1 = from s in sa
                     let words = s.Split(' ')
                     from w in words
                     let ws = w.ToLower()
                     where ws[0] == 'a' || ws[0] == 'e' || ws[0] == 'i' || ws[0] == 'o' || ws[0] == 'u'
                     select ws;
        }
        static  async void method4()
        {
            Console.WriteLine("method-4");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var task1 = print1();

            await task1;

            var task2 = print2();
            var task3 = print3();
           
            Task.WaitAll(task1,task2, task3);
            watch.Stop();

            Console.WriteLine("elapsed time - "+watch.ElapsedMilliseconds);

        }
        public static async Task print3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("print-3");
                Thread.Sleep(1000);
            });

        }
        public static async Task print2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("print-2");
                Thread.Sleep(2000);
            });  

        }
        public static async Task print1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("print-1");
                Thread.Sleep(7000);
            }); 

        }
        static void method3()
        {
           
            List<student> stud_list = new List<student>();
            stud_list.Add(new student { student_id = 1, student_name = "Ramu", student_age = 23, student_city = "NGKL" });
            stud_list.Add(new student { student_id = 2, student_name = "Hari", student_age = 29, student_city = "Banglore" });
            stud_list.Add(new student { student_id = 3, student_name = "Giri", student_age = 20, student_city = "Hyderabad" });
            stud_list.Add(new student { student_id = 4, student_name = "Syam", student_age = 27, student_city = "Warangal" });
            stud_list.Add(new student { student_id = 5, student_name = "Ramesh", student_age = 25, student_city = "Rangareddy" });
            stud_list.Add(new student { student_id = 6, student_name = "Somu", student_age = 30, student_city = "Banglore" });

            List<department> stud_dep = new List<department>();
            stud_dep.Add(new department { student_id=3,student_dep="EC"});
            stud_dep.Add(new department { student_id = 5, student_dep = "CS" });
            stud_dep.Add(new department { student_id = 1, student_dep = "EC" });

            Console.WriteLine("students with age>=25:");
            IEnumerable<student> ie = stud_list.Where<student>(x => x.student_age >= 25);
            ie = ie.OrderBy(x=>x.student_age);

            foreach(var obj in ie)
            {
                Console.WriteLine(obj.student_id+" "+obj.student_name+" "+obj.student_age+" "+obj.student_city);

            }

            Console.WriteLine("Students from the common city:");
            var op = from st1 in stud_list
                     join st2 in stud_list
                     on st1.student_city equals st2.student_city
                     where st1.student_id != st2.student_id
                     select st1;
            foreach(var obj in op)
            {
                Console.WriteLine(obj.student_name+" - "+obj.student_city);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("joining two collections data:");
            var list2 = from s in stud_list
                        join d in stud_dep on s.student_id equals d.student_id
                        select new { student_name=s.student_name,student_dep=d.student_dep};

            foreach(var obj in list2)
            {
                Console.WriteLine(obj.student_name+" "+obj.student_dep);
            }
                   
        }
        static void method2()
        {
            string s = "Hello World...!!!.....";
            s = s.ToLower();
            Dictionary<char,int> d = new Dictionary<char,int>();

            foreach(char c in s)
            {
                if(c!=' ')
                {
                    if (d.ContainsKey(c))
                    {
                        d[c] = d[c] + 1;
                    }
                    else
                    {
                        d.Add(c, 1);
                    }
                }
                
            }
            int mx = 0;
            char c2 = ' ';
            foreach(KeyValuePair<char,int>kvp in d)
            {
                if (kvp.Value>mx)
                {
                    mx = kvp.Value;
                    c2 = kvp.Key;
                }
                //Console.WriteLine(kvp.Key+"-"+kvp.Value);
            }
            Console.WriteLine("Max recurring char in the given string is : "+c2+"-"+mx);

        }
        static void method1()
        {
            List<int> lt = new List<int>();
            lt.Add(1); lt.Add(2); lt.Add(3); lt.Add(4); lt.Add(5); lt.Add(6);

            IEnumerable<int> ie = lt.Take<int>(3);
            IEnumerable<int> ie2 = lt.Skip(2).Take(2).Skip(1).Take(1);
            foreach (int i in ie2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class testProgram
    {

    }
}