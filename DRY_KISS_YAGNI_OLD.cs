using System;

class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }

    public void PrintArea()
    {
        Console.WriteLine("Circle area: " + CalculateArea());
    }
}

class Square
{
    public double Side;

    public Square(double side)
    {
        Side = side;
    }

    public double CalculateArea()
    {
        return Side * Side;
    }

    public void PrintArea()
    {
        Console.WriteLine("Square area: " + CalculateArea());
    }
}

class Triangle
{
    public double Base;
    public double Height;

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public void PrintArea()
    {
        Console.WriteLine("Triangle area: " + CalculateArea());
    }
}

class Program
{
    static void Main()
    {
        var circle = new Circle(5);
        var square = new Square(4);
        var triangle = new Triangle(3, 6);

        circle.PrintArea();
        square.PrintArea();
        triangle.PrintArea();
    }
}
