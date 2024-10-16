using System;

public class Vehicle
{
    public void Start()
    {
        Console.WriteLine($"{GetType().Name} is starting");
    }

    public void Stop()
    {
        Console.WriteLine($"{GetType().Name} is stopping");
    }
}

public class Car : Vehicle
{
}

public class Truck : Vehicle
{
}

public class Program
{
    public static void Main()
    {
        Vehicle car = new Car();
        car.Start();
        car.Stop();

        Vehicle truck = new Truck();
        truck.Start();
        truck.Stop();
    }
}
