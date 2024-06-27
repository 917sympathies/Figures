namespace Figures.Models;

public class Triangle : Figure, ITriangle
{
    public int SideA { get; }
    public int SideB { get; }
    public int SideC { get; }
    
    public Triangle(int sideA, int sideB, int sideC)
    {
        if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB) 
            throw new ArgumentException("Треугольник с такими сторонами не существует");
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    public override double GetArea()
    {
        var halfP = (SideA + SideB + SideC) / (double)2;
        return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
    }

    public bool IsRight()
    {
        if (SideA > SideB && SideA > SideC)
        {
            return SideA * SideA == (SideB * SideB) + (SideC * SideC);
        }
        else if (SideB > SideA && SideB > SideC)
        {
            return SideB * SideB == (SideA * SideA) + (SideC * SideC);
        }
        else if (SideC > SideA && SideC > SideB)
        {
            return SideC * SideC == (SideB * SideB) + (SideA * SideA);
        }
        else
        {
            return false;
        }
    }
}