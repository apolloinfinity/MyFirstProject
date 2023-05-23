using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.encapsulation
{
    internal class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee lynda = new Employee();

            alex.SetSalary(140000);
            //alex.bonus = 20000;
            alex.CalculateTotalPay();
            Console.WriteLine("Bonus: ", alex.GetBonus());


            lynda.SetSalary(100000);
            //lynda.bonus = 20000;
            lynda.CalculateTotalPay();
        }
    }
}
