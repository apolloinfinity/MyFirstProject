using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleArray
    {
        static void Main()
        {
            int[] a = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine(a[3]);   
            
            a[4] = 55;
            Console.WriteLine(a[4]);

            for(int i = 0; i <  a.Length; i++)
            {
                Console.WriteLine("i = " + a[i]);
            }
            Console.WriteLine("------------");    
            // looping using foreach
            foreach (int temp in a)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("------------");
            // initializing array then assigning values.
            int[] x = new int[6];
            x[0] = 10;
            x[3] = 50;
            foreach (int z in x)
            {
                Console.WriteLine(z);
            }
        }
    }
}
