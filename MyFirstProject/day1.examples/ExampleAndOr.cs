using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleAndOr
    {
        static void Main()
        {
            int x = 10; int y = -10;

            if(x >= 0 && y >= 0)
            {
                Console.WriteLine("Both numbers are positive");
            } else if (x >= 0 || y >= 0)
            {
                Console.WriteLine("at least one number is positive");
            } else
            {
                Console.WriteLine("both numbers are negative");
            }
        }
    }
}
