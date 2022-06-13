using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Practise
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number a");
            Console.WriteLine("enter the number b");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float sum, sub,multi,div;
            Console.WriteLine("Enter 1 for add");
            Console.WriteLine("enter 2for sub");
            Console.WriteLine("enter 3 for multi");
            Console.WriteLine("enter 4 for divi");
            int x = Convert.ToInt32(Console.ReadLine());
            


            if (x == 1)
            { 
                sum=(a +b);
                Console.WriteLine("addtion" + sum); 
            }

            else if (x == 2)
            {
                sub = (a - b);
                Console.WriteLine(sub);

            }
            else if (x==3)
            {
                multi = a * b;
                Console.WriteLine(multi);

            }
            else if (x == 4)
            {
                div = a / b;
                Console.WriteLine(div);
            }

            
            

            

        }
      
    }
}
