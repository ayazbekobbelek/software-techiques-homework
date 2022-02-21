using System;
using System.Collections.Generic;
using System.Text;
namespace exercise2
{
    public class Editbox : Controls.Textbox, IShape
    {
         int x;
         int y;
         int width;
         int height;
        public Editbox(int x, int y, int w, int h) : base(x, y, w, h)
        {
            this.x = x;
            this.y = y;
            this.width = w;
            this.height = h;
        }
        public double getArea()
        {
            return width * height;
        }
        public string getShapeName()
        {
            return "Textbox";
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }

        
    }

}