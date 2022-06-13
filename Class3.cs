using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class program
    {
       
        
            public int x, y;
            public int res;

        public void Display()
        {
            res = x + y;
            Console.WriteLine("ans" + res);

        }
    }
    internal class Class3
    {
        public int x, y;
        public int res;

        public void Display()
        {
            res = x + y;
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number x and y" );
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            program b1 = new program();
            b1.Display();
            

        }
        
    }
}
