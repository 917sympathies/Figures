namespace Figures.Interfaces;

public interface ITriangle : IFigure
{
    int SideA { get; }
    int SideB { get; }
    int SideC { get; }
    bool IsRight();
}