class Circle : Shape
{
    private int radius;
    private const double PI = 3.14;
    public Circle(int x, int y, int radius)
    {
        this.x = x; 
        this.y = y; 
        this.radius = radius;
    }

    public override double area()
    {
        return PI * radius * radius;
    }

    public override string getShape()
    {
        return "Circle";
    }
}
