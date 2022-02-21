using System;
using System.Collections.Generic;
using System.Text;
namespace exercise2
{
    public class Circle : ShapeBase
    {
         double radius;
         const double PI = 3.14;
        public Circle(int x, int y, double radius) :
            base(x, y)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return PI * this.radius * this.radius;
        }

        public override string getShapeName()
        {
            return "Circle";
        }
    }

}