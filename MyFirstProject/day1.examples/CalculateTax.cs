using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class CalculateTax
    {
        static void Main()
        {
            double salary = 45000;
            if(salary <= 8350) {
                Console.WriteLine(salary * .1);
            } else if (salary > 8350 && salary <= 33950)
            {
                Console.WriteLine(salary * .15);
            } else
            {
                Console.WriteLine(salary * .25);            }
        }
    }
}
