using Figures;
using Figures.Shapes;

namespace FiguresTesting;

public class Tests
{
    [Test]
    public void Check_Correct_Triangle_Square_Return()
    {
        var triangle = new Triangle(3, 4, 5);
        var ans = triangle.GetArea(); 
        Assert.AreEqual(ans, 6);
    }

    [Test]
    public void Non_Existed_Triangle_Passed()
    {
        try
        {
            var triangle = new Triangle(1, 2, 3);
            Assert.Fail();
        }
        catch (Exception e)
        {
            Assert.Pass();
        }
    }

    [Test]
    public void Check_If_Triangle_Is_Right()
    {
        var triangle = new Triangle(7, 24, 25);
        var result = triangle.IsRight();
        Assert.AreEqual(result, true);
    }

    [Test]
    public void Check_If_Triangle_Is_Not_Right()
    {
        var triangle = new Triangle(7, 23, 25);
        var result = triangle.IsRight();
        Assert.AreEqual(result, false);
    }
    
    [Test]
    public void Check_If_Circle_Area_Is_Correct()
    {
        var circle = new Circle(radius: 4);
        var result = Math.Round(circle.GetArea(), 2);
        Assert.AreEqual(result, 50.27);
    }
}