using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTaskMetanit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Computer comp = new Computer();
            //comp.Launch("Windows 10");
            //Console.WriteLine(comp.OS.Name);

            //comp.OS = OS.GetInstance("Linux");
            //Console.WriteLine(comp.OS.Name);

            #region MultiThreading
            (new Thread(()=>{

                Computer comp2 = new Computer();
                comp2.OS = OS.GetInstance("Windows 10");
                Console.WriteLine(comp2.OS.Name);
            })).Start();

            Computer comp = new Computer();
            comp.Launch("Windows 8");
            Console.WriteLine(comp.OS.Name);
            #endregion


            Console.ReadLine();
        }
    }
}
