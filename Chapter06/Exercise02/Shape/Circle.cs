using static System.Console;

namespace Geometry;

public class Circle : Square
{
    private double _radius;

    public virtual double Radious
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public Circle() { }

    public Circle(double radius) : base (Height:radius*2)
    {
        Radious = radius;
    }

    public override double Area
    {
        get { return Math.PI*_radius*_radius; }
    }
}