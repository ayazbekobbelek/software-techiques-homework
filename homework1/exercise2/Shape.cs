public abstract class Shape
{
    protected int x;
    protected int y;


    public virtual string getShape()
    {
        return "Shape";
    }
    public int getX() { return x; }
    public int getY() { return y; }
    public abstract double area();

}
