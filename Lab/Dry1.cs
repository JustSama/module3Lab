using System;

public class OrderService
{
    public void CreateOrder(string productName, int quantity, double price)
    {
        double totalPrice = CalculateTotalPrice(quantity, price);
        Console.WriteLine($"Order for {productName} created. Total: {totalPrice}");
    }

    public void UpdateOrder(string productName, int quantity, double price)
    {
        double totalPrice = CalculateTotalPrice(quantity, price);
        Console.WriteLine($"Order for {productName} updated. New total: {totalPrice}");
    }

    private double CalculateTotalPrice(int quantity, double price)
    {
        return quantity * price;
    }
}

public class Program
{
    public static void Main()
    {
        OrderService orderService = new OrderService();
        orderService.CreateOrder("Laptop", 2, 799.99);
        orderService.UpdateOrder("Laptop", 3, 799.99);
    }
}
