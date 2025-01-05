public class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int X => x;
    public int Y => y;
}

public class Figure
{
    private Point[] points;
    public string Name { get; set; }

    public Figure(Point p1, Point p2, Point p3) : this(new Point[] { p1, p2, p3 })
    {
        Name = "Треугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4) : this(new Point[] { p1, p2, p3, p4 })
    {
        Name = "Четырехугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(new Point[] { p1, p2, p3, p4, p5 })
    {
        Name = "Пятиугольник";
    }

    private Figure(Point[] points)
    {
        this.points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length; i++)
        {
            Point current = points[i];
            Point next = points[(i + 1) % points.Length];
            perimeter += LengthSide(current, next);
        }

        return perimeter;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(4, 3);
        Point p4 = new Point(0, 3);
        Figure triangle = new Figure(p1, p2, p3, p4);

        Console.WriteLine($"Название фигуры: {triangle.Name}");
        Console.WriteLine($"Периметр фигуры: {triangle.PerimeterCalculator()}");
    }
}