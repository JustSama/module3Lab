using System;

public class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}

public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.Add(5, 3);
    }
}
