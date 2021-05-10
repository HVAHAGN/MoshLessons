using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class OverloadIndexer
    {
        private string[] strArr = new string[10];
        public string this[int index]
        {
            get
            {
                if (index<0 || index>=strArr.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return strArr[index];
            }
            set
            {
                if (index < 0 || index >= strArr.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                strArr[index] = value;
            }
        } 
        //string type Indexer
        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (str.ToLower() == name.ToLower())
                    {
                        return str;
                    }
                }
                return null;
            }
        }
    }
}
