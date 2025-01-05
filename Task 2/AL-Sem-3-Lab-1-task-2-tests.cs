using System.Drawing;
using NUnit.Framework;

[TestFixture]
public class RectangleTests
{
    [Test]
    public void TestAreaCalculation()
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Assert.AreEqual(50, rectangle.Area, "Площадь должна быть 50 для сторон 5 и 10.");
    }

    [Test]
    public void TestPerimeterCalculation()
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Assert.AreEqual(30, rectangle.Perimeter, "Периметр должен быть 30 для сторон 5 и 10.");
    }

    [Test]
    public void TestAreaWithDifferentSides()
    {
        Rectangle rectangle = new Rectangle(4.5, 6.5);
        Assert.AreEqual(29.25, rectangle.Area, 0.01, "Площадь должна быть 29.25 для сторон 4.5 и 6.5.");
    }

    [Test]
    public void TestPerimeterWithDifferentSides()
    {
        Rectangle rectangle = new Rectangle(4.5, 6.5);
        Assert.AreEqual(22, rectangle.Perimeter, 0.01, "Периметр должен быть 22 для сторон 4.5 и 6.5.");
    }
}