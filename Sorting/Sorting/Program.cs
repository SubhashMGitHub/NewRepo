using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world!!!");
            int n;
            Console.WriteLine("Give the length of the list:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the number["+i+"]:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int j=0;j<n-1;j++)
            {
                for(int k=j+1;k<n;k++)
                {
                    int temp = 0;
                    if(arr[k]<arr[j])
                    {
                        temp = arr[k];
                        arr[k] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

        }
    }
}
