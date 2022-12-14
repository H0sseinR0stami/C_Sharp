namespace Geometry;

public class Square: Rectangle
{
    public Square() { }

    public Square(double Height): base(Height: Height,Width: Height)
    {
        this.Height = Height;
    }

    public override double Area
    {
        get { return Height * Height; }
    }
}