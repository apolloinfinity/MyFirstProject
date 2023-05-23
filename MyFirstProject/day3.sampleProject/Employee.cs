﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.sampleProject
{
    internal class Employee
    {
        private string empName;
        public int empGrade { private set; get; }

        public Employee(string empName, int empGrade)
        {
            this.empName = empName;
            this.empGrade = empGrade;   
        }

        public string ReturnNameGrade()
        {
            string temp = empName + "(" + empGrade + ")";
            return temp;
        }
    }
}
