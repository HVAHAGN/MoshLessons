using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Coordinate str = new Coordinate();
            //str.SetOrigin();
            //var coordinte =Coordinate.GetOrigin();
            //Console.WriteLine(str.x+" "+str.y+" "+coordinte.x);
            //int i = 100;
            //Console.WriteLine(i);
            //ChangeValue(i);
            //Console.WriteLine(i);
            Employee emp = new Employee();
            Console.WriteLine(emp.EmpId);
            Console.ReadLine();
        }
        public struct Coordinate
        {
            public int x;
            public int y;
            public void SetOrigin()
            {
                this.x = 0;
                this.y = 0;
            }
            public static Coordinate GetOrigin()
            {
                return new Coordinate();
            }
        }
     public static void ChangeValue(int x)
        {
            x= 200;
            Console.WriteLine(x);

        }
    }

}
