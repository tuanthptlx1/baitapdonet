using System;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    protected Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public abstract void DisplayProductInfo();
    public abstract void ApplyDiscount(decimal percentage);
}
public interface ISellable
{
    void Sell(int quantity);
    bool IsInStock();
}
public class MobilePhone : Product, ISellable
{
    public MobilePhone(string name, decimal price, int stock) : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Mobile Phone - Name: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (IsInStock() && Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Mobile Phones. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock or product is not available.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Laptop : Product, ISellable
{
    public Laptop(string name, decimal price, int stock) : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop - Name: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (IsInStock() && Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Laptops. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock or product is not available.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Accessory : Product, ISellable
{
    public Accessory(string name, decimal price, int stock) : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory - Name: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (IsInStock() && Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Accessories. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock or product is not available.");
        }
    }


    public bool IsInStock()
    {
        return Stock > 0;
    }
}
class Program
{
    static void Main()
    {

        MobilePhone phone = new MobilePhone("samsung galaxy S24", 2500.99m, 6);
        Laptop laptop = new Laptop("hp victus", 1999.69m, 9);
        Accessory accessory = new Accessory("USB-C", 29.99m, 40);

        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();


        phone.Sell(3);
        Console.WriteLine($"Phone in stock: {phone.IsInStock()}");

        laptop.Sell(1);
        Console.WriteLine($"Laptop in stock: {laptop.IsInStock()}");

        accessory.Sell(5);
        Console.WriteLine($"Accessory in stock: {accessory.IsInStock()}");


        phone.ApplyDiscount(10);
        laptop.ApplyDiscount(15);
        accessory.ApplyDiscount(5);
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();
    }
}

