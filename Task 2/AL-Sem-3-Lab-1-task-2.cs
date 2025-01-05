using System;

public class Rectangle
{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    private double CalculateArea()
    {
        return sideA * sideB;
    }

    private double CalculatePerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину стороны A:");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину стороны B:");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(sideA, sideB);

        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
    }
}