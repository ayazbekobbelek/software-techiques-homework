class Editbox : Controls.Textbox
{
    private int x;
    private int y;
    private int width;
    private int height; 
    public Editbox(int x, int y, int w, int h) : base(x, y, w, h)
    {
        this.x = x;    
        this.y = y;
        this.width = w;
        this.height = h;
    }
    public double area()
    {
        return width * height;
    }
    public string getShape()
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
