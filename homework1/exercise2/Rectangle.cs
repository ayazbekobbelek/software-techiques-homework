class Rectangle : Shape
{
    private double width;
    private double height;
    public Rectangle (int x, int y, double width, double height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public override double area()
    {
        return width * height;
    }
    public override string getShape()
    {
        return "Rectangle";
    }

}   
