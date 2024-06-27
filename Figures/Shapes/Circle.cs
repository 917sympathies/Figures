namespace Figures.Models;

public class Circle : Figure, ICircle
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}