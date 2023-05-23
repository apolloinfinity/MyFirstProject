using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.constructor
{
    internal class TestSmallBox
    {
        static void Main()
        {
            SmallBox fedex1 = new SmallBox(7,8);
            //fedex1.length = 10;
            //fedex1.width = 4;
            fedex1.CalculateArea();


            SmallBox fedex2 = new SmallBox();   
            //fedex2.length = 6;  
            //fedex2.width = 5;   
            fedex2.CalculateArea();
        }
    }
}
