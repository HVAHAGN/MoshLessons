using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int number;
            var a = int.TryParse("15", out number);
            if (a)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }


            Console.ReadLine();
        }



        public static void UseParams()
        {
            var caluclator = new Calculator();
            Console.WriteLine(caluclator.Add(1, 2, 3, 5));
        }
        public static void UserPoint()
        {
            try
            {
                var point = new Point(20, 15);
                point.Move(null);
                Console.WriteLine($"New location is {point.X} {point.Y}");
                point.Move(new Point(1, 2));
                Console.WriteLine($"New location is {point.X} {point.Y}");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
