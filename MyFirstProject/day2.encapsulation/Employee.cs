using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.encapsulation
{
    internal class Employee
    {
        private double salary;
        private double bonus;

        public double GetBonus ()
        {
            return bonus;
        }
        public void SetSalary(double salary)
        {
            if(salary < 40000 || salary > 150000)
            {
                Console.WriteLine("Please check salary");
                this.salary = 0;
                this.bonus = 0;
            } else
            {
                this.salary = salary;
                this.bonus = salary * .20;
            }
        }

        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine(totalPay);        
        }
    }
}
