using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncVsThreads
{
    class Program
    {
        static object obj = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Code 1");
            Console.WriteLine("Code 2 "+Thread.CurrentThread.ManagedThreadId);
            SomeMethod();
            Console.WriteLine("Code 7");
            Console.WriteLine("Code 8");
            


            Console.ReadLine();
        }
        static async void SomeMethod()
        {
           
            Console.WriteLine("Code 3");
             Task.Delay(10000);
            Console.WriteLine("Code 4 Current thread"+Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Code 5");
            
        }
    }
}
