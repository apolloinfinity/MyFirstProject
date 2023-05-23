using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.examples
{
    internal class TestBox
    {
        static void Main()
        {
            Box ups, fedex;
            ups = new Box();
            fedex = new Box();

            ups.length = 10;
            ups.width = 5;
            int total = ups.CalculateArea(3, 4);
           

            fedex.length = 7;
            fedex.width = 5;
            total += fedex.CalculateArea(6, 8);

            Console.WriteLine("Total area: " + total);
        }
    }
}
