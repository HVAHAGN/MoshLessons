using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# allows us to define custom indexers, generic indexers, and also overload indexers
            //StringDataStore dataStore = new StringDataStore();
            //dataStore[0] = "One";
            //dataStore[11] = "Eleven";
            //Console.WriteLine(dataStore[11]);
            GenericIndexer<int> grades = new GenericIndexer<int>(3);
            grades[0] = 10;
            grades[1] = 12;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine(grades[i]);
            //}
            GenericIndexer<string> names = new GenericIndexer<string>(3);
            names[0] = "Stive";
            names[1] = "John";
            names[2] = "George";

            OverloadIndexer over = new OverloadIndexer();
            over[0] = "one";
            over[1] = "two";
            over[2] = "three";
            Console.WriteLine(over["one"]);
            Console.ReadLine();
        }
    }
}
