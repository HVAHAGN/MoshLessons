using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Developer dev = new PanelDeveloper("OOO Kirpich");
            House house2 = dev.Create();
            dev = new WoodDeveloper("Personal constructor");
            House house = dev.Create();


            Console.ReadLine();
        }
    }
}
