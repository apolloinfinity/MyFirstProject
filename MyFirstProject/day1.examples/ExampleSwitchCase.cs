using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleSwitchCase
    {
        static void Main()
        {
            string j = "Three";

            switch(j)
            {
                case "Zero":
                    Console.WriteLine("Value is 0");
                    break;
                case "One":
                    Console.WriteLine("Value is 1");
                    break;
                case "Two":
                    Console.WriteLine("Value is 2");
                    break;

                case "Three":
                    Console.WriteLine("Value is 3");
                    break;

                default: Console.WriteLine("value not found");
                        break;
            }
        }
    }
}
