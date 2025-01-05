using System.Drawing;
using NUnit.Framework;

[TestFixture]
public class FigureTests
{
    [Test]
    public void TrianglePerimeterTest()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(4, 3);
        Figure triangle = new Figure(p1, p2, p3);

        double expectedPerimeter = 12; // (4 + 3 + 5)
        Assert.AreEqual(expectedPerimeter, triangle.PerimeterCalculator(), "Периметр треугольника должен быть 12.");
    }

    [Test]
    public void QuadrilateralPerimeterTest()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(4, 3);
        Point p4 = new Point(0, 3);
        Figure quadrilateral = new Figure(p1, p2, p3, p4);

        double expectedPerimeter = 14; // 4 + 3 + 4 + 3
        Assert.AreEqual(expectedPerimeter, quadrilateral.PerimeterCalculator(), "Периметр четырёхугольника должен быть 14.");
    }

    [Test]
    public void PentagonPerimeterTest()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(5, 3);
        Point p4 = new Point(2, 4);
        Point p5 = new Point(0, 3);
        Figure pentagon = new Figure(p1, p2, p3, p4, p5);

        // Примерно рассчитываем периметр
        double expectedPerimeter =
            4 + // p1 to p2
            5 + // p2 to p3
            Math.Sqrt(Math.Pow(5 - 2, 2) + Math.Pow(3 - 4, 2)) + // p3 to p4
            Math.Sqrt(Math.Pow(2 - 0, 2) + Math.Pow(4 - 3, 2)) + // p4 to p5
            3; // p5 to p1

        Assert.AreEqual(expectedPerimeter, pentagon.PerimeterCalculator(), 0.01, "Периметр пятиугольника должен соответствовать расчету.");
    }
}