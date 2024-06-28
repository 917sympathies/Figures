using Figures.Interfaces;

namespace Figures.Shapes;

public class Circle : Figure, ICircle
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius), "Can't be less than or equal to zero");
        Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}