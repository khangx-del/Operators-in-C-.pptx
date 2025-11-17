using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_.pptx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upg1");
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;
            int num5 = 50;
            int num6 = 60;
            
            Console.WriteLine();
            Console.WriteLine("upg2");
            int result1 = num1 + num2;
            int result2 = num3 * num4;
            int result3 = num5 % num6;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine();
            
            Console.WriteLine("upg3");
            Console.WriteLine($"{num6++}");
            Console.WriteLine($"{++num6}");
            Console.WriteLine($"{num6--}");
            Console.WriteLine($"{--num6}");
                
            Console.WriteLine();
            Console.WriteLine("upg4");
        
            Console.WriteLine($"{num1 += num5}");
            Console.WriteLine($"{num1 -= num5}");
            Console.WriteLine($"{num1 *= num5}");
            Console.WriteLine($"{num1 /= num5}");
            Console.WriteLine($"{num1 %= num5}");

        }
    }
}
