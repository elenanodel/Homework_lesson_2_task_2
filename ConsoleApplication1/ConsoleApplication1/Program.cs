using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Solution of equation 4/5 * x - 20 = 0");
            Console.WriteLine("Press 'Enter'...");
            Console.ReadLine();

            Console.WriteLine("4/5 * x = 20");
            Console.WriteLine("x = 20 : 4/5");
            Console.WriteLine("Press 'Enter' and you'll see the answer...");
            Console.ReadLine();

            //declaring variables and solving 
            const int a = 20;
            decimal b = decimal.Divide(4, 5);
            decimal x;

            x = a / b;

            Console.WriteLine("x = " + x);
            Console.ReadLine();
        }
    }
}
