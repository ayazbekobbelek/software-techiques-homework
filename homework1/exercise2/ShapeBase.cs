using System;
using System.Collections.Generic;
using System.Text;
namespace exercise2
{
    public abstract class ShapeBase : IShape

    {
        protected int x;
        protected int y;
        public ShapeBase(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX() { return x; }
        public int getY() { return y; }
        public abstract double getArea();

        public virtual string getShapeName()
        {
            return "Shape";
        }




    }
}
