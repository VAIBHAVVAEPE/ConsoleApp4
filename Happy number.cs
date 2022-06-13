using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Happy_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number only 2 digit");
            int a=Convert.ToInt32(Console.ReadLine());
            
            int rem, digit, power,sum=0,sum2=0;
            while (sum2!=1)
            {
                while(a!=0)
                {

                    rem = a % 10;
                    digit = rem * rem;
                    sum = digit + sum;
                    a = a / 10;

                    //int digit2 = power * power;
                    
                }

                a = sum;
                sum2 = sum;
                sum = 0;
                if(sum2<9)
                {
                    break;
                }
                
            }

            if (sum2 == 1)
            {
                Console.WriteLine("happy ");
            }
            else
            {
                Console.WriteLine("not happy");
            }
        }
    }
}
