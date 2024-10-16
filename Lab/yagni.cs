using System;

public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Square
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double CalculateArea()
    {
        return _side * _side;
    }
}

public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

        Square square = new Square(4);
        Console.WriteLine($"Square Area: {square.CalculateArea()}");

        MathOperations mathOperations = new MathOperations();
        int result = mathOperations.Add(3, 5);
        Console.WriteLine($"Addition Result: {result}");
    }
}
