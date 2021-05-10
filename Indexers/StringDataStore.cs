using System;

namespace Indexers
{
    public class StringDataStore
    {
        private string[] strArr = new string[10]; //internal data storage
        //public string this[int index]
        //{
        //    get
        //    {
        //        if (index<0 || index>strArr.Length)
        //        {
        //            throw new IndexOutOfRangeException("Index out of range");
        //        }
        //        return strArr[index];
        //    }
        //    set {
        //        if (index<0 || index>=strArr.Length)
        //        {
        //            throw new IndexOutOfRangeException("Index out of range");
        //        }
        //        strArr[index] = value;
        //    }
        //}
        public string this [int index]
        {
            get => strArr[index];
            set => strArr[index] = value;
        }
    }
}
