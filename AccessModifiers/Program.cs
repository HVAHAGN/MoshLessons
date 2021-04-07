using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1991, 1, 1));
            var birtDate = person.GetBirtDate();
            Console.WriteLine(birtDate);

            Console.ReadLine();
        }
    }
}
