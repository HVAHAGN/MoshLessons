using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleValueDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            //create list one and more values
            List<string> valSetOne = new List<string>();
            valSetOne.Add("Apple");
            valSetOne.Add("Aeroplane");
            //create list two and store values
            List<string> valSetTwo = new List<string>();
            valSetTwo.Add("Bat");
            valSetTwo.Add("Banana");

            //create list three and store value
            List<string> valSetThree = new List<string>();
            valSetThree.Add("Cat");
            valSetThree.Add("Car");

            map.Add("A", valSetOne);
            map.Add("B", valSetTwo);
            map.Add("C", valSetThree);

            foreach (KeyValuePair<string, List<string>> kvp in map)
            {
                foreach (string value in kvp.Value)
                {
                    Console.WriteLine("Key={0} Value={1}",kvp.Key,value);
                }
            }

            Console.ReadLine();
        }
    }
}
