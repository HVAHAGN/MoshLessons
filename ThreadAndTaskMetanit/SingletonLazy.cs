using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAndTaskMetanit
{
    public class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> lazy = new Lazy<SingletonLazy>(() = new SingletonLazy());
        public string Name { get; private set; }
        public SingletonLazy()
        {
            Name = System.Guid.NewGuid().ToString();
        }
        public static SingletonLazy GetInstance()
        {
            return lazy.Value;
        }
    }
}
