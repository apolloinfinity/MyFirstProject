using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.sampleProject
{
    internal class XYZCompany
    {
        static void Main(string[] args)
        {
            Employee alex = new Employee("Alex", 6);
            Employee lynda = new Employee("Alex", 7);
            Employee john = new Employee("Alex", 3);
            Employee sara = new Employee("Alex", 7);
            Employee james = new Employee("Alex", 4);

            Department sales = new Department("XYZ Sales");
            sales.AddEmployee(alex);
            sales.AddEmployee(lynda);
            sales.AddEmployee(john);
            sales.describe();

            Department IT = new Department("XYZ IT");
            IT.AddEmployee(sara);
            IT.AddEmployee(james);
            IT.describe();
        }
    }
}

