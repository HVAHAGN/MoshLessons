using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_02
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
       // Action<Photo>
       //Func<Photo,bool>
        public void Processor(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            //var filter = new PhotoFilters();
            //filter.ApplyBirghtness(photo);
            //filter.ApplyContrast(photo);
            //filter.Resize(photo);
            photo.Save();
        }
    }
}
