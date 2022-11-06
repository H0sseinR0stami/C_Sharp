namespace Geometry;

public class Rectangle: Shape
{
    public Rectangle() { }

    public Rectangle(double Height,double Width)
    {
        this.Height = Height;
        this.Width = Width;
    }
    public override double Area
    {
        get { return Height * Width; }
    }
}
