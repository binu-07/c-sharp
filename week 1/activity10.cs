using System;

public class Program
{
    public static void Main()
    {
        //initiate variable
        double price, tax_rate,total_cost;

        //user input
        Console.WriteLine("Enter price");
        price= double.Parse(Console.ReadLine());
        Console.WriteLine("Enter tax-rate");
        tax_rate=double.Parse(Console.ReadLine());

        //operation
        total_cost=price*tax_rate/100;

        //Display the Answer
        Console.WriteLine("Enter total_cost"+total_cost);
    }
}