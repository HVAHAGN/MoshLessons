using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.Now;
            //Console.WriteLine("GetValueOrDefault "+date.GetValueOrDefault());
            // Console.WriteLine("HasValue "+date.HasValue);
            //  Console.WriteLine($"\"Start\" "+date);


            //int PlayerId = 1;
            //var student = new Student();
            //Console.WriteLine(student.Name);
            int a = 7;
            int b = a;
            Console.WriteLine(b);
            a = 10;
            Console.WriteLine(b+" "+a);

            Console.ReadLine();
        }
    }
}
