using Figures.Shapes;

namespace Figures.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Constructor_Throws_ArgumentOutOfRangeException(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }
    
    [Fact]
    public void GetArea_Returns_Correct_Answer()
    {
        const double radius = 4;
        var circle = new Circle(radius);
        var area = circle.GetArea();
        Assert.Equal(Math.PI * radius * radius, area);
    }
}