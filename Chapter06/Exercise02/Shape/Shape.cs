using static System.Console;

namespace Geometry;

public abstract class Shape
{
    private double _height;
    private double _width;

    public virtual double Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public virtual double Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public abstract double Area
    {
        get;
    }
}