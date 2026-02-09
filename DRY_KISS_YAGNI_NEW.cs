using System;

abstract class Shape
{
    public abstract double CalculateArea();

    public void PrintArea()
    {
        Console.WriteLine($"{GetType().Name} area: {CalculateArea()}");
    }
}

class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}

class Square : Shape
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public override double CalculateArea()
    {
        return _side * _side;
    }
}

class Triangle : Shape
{
    private double _base;
    private double _height;

    public Triangle(double @base, double height)
    {
        _base = @base;
        _height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * _base * _height;
    }
}

class Program
{
    static void Main()
    {
        Shape[] shapes =
        {
            new Circle(5),
            new Square(4),
            new Triangle(3, 6)
        };

        foreach (var shape in shapes)
        {
            shape.PrintArea();
        }
    }
}
