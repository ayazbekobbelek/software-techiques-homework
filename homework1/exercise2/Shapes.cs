using System;
using System.Collections.Generic;
using System.Text;
namespace exercise2
{
    public class Shapes
    {
        private List<IShape> shapes;

        public Shapes()
        {
            this.shapes = new List<IShape>();
        }

        public void listAll()
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.getShapeName()}\t" +
                    $" Coordinates : ({shape.getX()}, {shape.getY()})\t " +
                    $"Area: {shape.getArea()}");

            }
        }

        public void addShape(IShape shape)
        {
            shapes.Add(shape);
        }
    }

}