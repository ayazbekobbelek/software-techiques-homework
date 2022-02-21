using System;
using System.Collections.Generic;
using System.Text;
namespace exercise2
{
    public class Rectangle : ShapeBase
    {
        double width;
        double height;
        public Rectangle(int x, int y, double width, double height) :
            base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override double getArea()
        {
            return this.width * this.height;
        }
        public override string getShapeName()
        {
            return "Rectangle";
        }

    }

}