using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleString
    {
        static void Main()
        {
            string x = "David Beckham";
            Console.WriteLine("Hello " + x);
            Console.WriteLine(x.ToUpper());
            Console.WriteLine(x.Substring(2));
            Console.WriteLine(x.Substring(4, 5));
            Console.WriteLine(x.IndexOf("v"));
            Console.WriteLine(x[1]);

            Console.WriteLine("------------");

            string[] y = { "one", "two", "three" };
            foreach(string z in y)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("------------");
            // converting string to an integer
            string age = "35";
            string sal = "115000";

            int g = Convert.ToInt32(age);
            Console.WriteLine(g / 2);
            Console.WriteLine(Convert.ToDouble(sal) * .02);
        }
    }
}
