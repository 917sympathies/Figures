using Figures.Shapes;

namespace Figures.Tests;

public class TriangleTests
{
    [Fact]
    public void GetArea_Returns_Correct_Triangle_Square()
    {
        const int sideA = 3;
        const int sideB = 4;
        const int sideC = 5;
        
        var triangle = new Triangle(sideA, sideB, sideC);
        var area = triangle.GetArea();
        
        Assert.Equal(6, area);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(0, 0 ,0)]
    [InlineData(0, 0 ,1)]
    [InlineData(-1, 0 ,0)]
    [InlineData(-1, -1 ,-1)]
    public void Constructor_Throws_ArgumentException_For_Non_Existing_Triangle(int sideA, int sideB, int sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Fact]
    public void Is_IsRight_Method_Return_Correct_Answer()
    {
        const int sideA = 7;
        const int sideB = 24;
        const int sideC = 25;
        
        var triangle = new Triangle(sideA, sideB, sideC);
        var isRight = triangle.IsRight();
        
        Assert.True(isRight);
    }

    [Fact]
    public void Check_If_Triangle_Is_Not_Right()
    {
        const int sideA = 7;
        const int sideB = 24;
        const int sideC = 25;
        
        var triangle = new Triangle(sideA, sideB, sideC);
        var isRight = triangle.IsRight();
        Assert.True(isRight);
    }
}