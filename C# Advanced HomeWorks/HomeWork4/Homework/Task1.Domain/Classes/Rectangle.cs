using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Domain.Classes
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public override double GetArea()
        {
            if(SideA <=0 || SideB <= 0)
            {
                throw new ArgumentException("Side A or Side B can not be negative or 0");
            }
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            if (SideA <= 0 || SideB <= 0)
            {
                throw new ArgumentException("Side A or Side B can not be negative or 0");
            }
            return 2 * (SideA + SideB);
        }
    }
}
