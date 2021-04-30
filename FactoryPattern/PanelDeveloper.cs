using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n):base(n)
        {

        }
        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
