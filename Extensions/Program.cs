using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var post = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets";
            while (true)
            {

                Console.WriteLine("Input number how many words do you want to see...");
                var input = Console.ReadLine();
                int number;
                var num = int.TryParse(input, out number);

                if (!num)
                {
                    Console.WriteLine("You entered not valid number... Please try again...");
                }
                else
                {
                    var result = Extensions.Shorten(post, number);
                    var numbers = new List<int>() { 0, 1, 20, 5, 3, 15, 51 };
                    var max = Extensions.GetMax(numbers);
                    Console.WriteLine($"{result}, Max number is {max}");
                }
            }
            

            Console.ReadLine();
        }
    }
}
