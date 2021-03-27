using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new PhotoProcessor();
            var filters = new PhotoFilters();
            // PhotoProcessor.PhotoFilterHandler filterHandler= filters.ApplyBirghtness;
            Action<Photo> filterHandler = filters.ApplyBirghtness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEye;

            process.Processor("Path", filterHandler);




            Console.ReadLine();
        }
        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Red eyes removed");
        }
    }
}
