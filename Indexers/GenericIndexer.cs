using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class GenericIndexer<T>
    {
        private T[] internalStore;
        public GenericIndexer()
        {
            internalStore = new T[10];
        }
        public GenericIndexer(int length)
        {
            internalStore = new T[length];
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= internalStore.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return internalStore[index];
            }
            set
            {
                if (index < 0 || index >= internalStore.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                internalStore[index] = value;
            }
        }
        public int Length { get { return internalStore.Length; } }
    }
}

