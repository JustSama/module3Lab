using System;

public class SimpleService
{
    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}

public class Client
{
    public void Execute()
    {
        SimpleService service = new SimpleService();
        service.DoSomething();
    }
}

public class Program
{
    public static void Main()
    {
        Client client = new Client();
        client.Execute();
    }
}
