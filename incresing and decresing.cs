using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class incresing_and_decresing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the  number = ");
            int a = Convert.ToInt32(Console.ReadLine());
            int next;
            next = a % 10;
            int prev;
            a= a / 10;
            bool inc = true;
            bool dec = true;


             while(a>0)
             {
                prev = a% 10;

                if(prev>next)
                {
                    inc = false;
                }
                else if(prev<next)
                {
                    dec = false;    
                }
                a= a / 10;  
                next = prev;
                
             }
             if(inc==true)
             {
                Console.WriteLine("increasing");
             }
             else if(dec==true)
             {
                Console.WriteLine("decreasing");
             }
             else if (inc==false||dec==false)
             {
                Console.WriteLine("Bouncy");
             }
            
           
        }
    }
}
