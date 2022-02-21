using System;
using System.Collections.Generic;
using System.Text;
namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes sh = new Shapes();
            sh.addShape(new Rectangle(15, 20, 40, 50));
            sh.addShape(new Rectangle(-4, 17, 12, 5));
            sh.addShape(new Rectangle(24, 56, 32, 78));

            sh.addShape(new Circle(12, 23, 55));
            sh.addShape(new Circle(-45, 12, 77));
            sh.addShape(new Circle(55, 88, 11));

            sh.addShape(new Editbox(15, 20, 40, 50));
            sh.addShape(new Editbox(-4, 17, 12, 5));
            sh.addShape(new Editbox(24, 56, 32, 78));

            sh.listAll();



        }
    }
}