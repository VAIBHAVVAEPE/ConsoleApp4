using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
    //Peogram to calculate Area and Parameter of squar//   
{
    internal class Class2
    { 
        static void Main (string[] args)
        {
            Console.WriteLine("Side of Square");
            float side = Convert.ToSingle(Console.ReadLine());
        float area = side * side;
        float parameter = 4 * side;
        Console.WriteLine("Area of square=" + area);
        Console.WriteLine("parameter of square=" + parameter);

            
        }
    }
}
