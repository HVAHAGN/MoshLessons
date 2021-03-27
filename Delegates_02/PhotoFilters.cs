using System;

namespace Delegates_02
{
    public class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        public void ApplyBirghtness(Photo photo)
        {
            Console.WriteLine("Applied Birghtness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applied Contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resized");
        }
    }
}