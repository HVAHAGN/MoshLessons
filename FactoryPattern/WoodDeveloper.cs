using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n):base(n)
        {

        }
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
