using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum wd { mon,tue,wed=7,thu,fri,sat,sun}
    static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            Console.WriteLine("values in the enum:");
            foreach(int value in Enum.GetValues(typeof(wd)))
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("names in the enum:");
            foreach(string name in Enum.GetNames(typeof(wd)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
