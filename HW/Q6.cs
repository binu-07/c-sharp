using System;

public class Program
{
    public static void Main()
    {
        int num1,num2,product=0;

        Console.WriteLine("num1");
        num1=int.Parse(Console.ReadLine());

        Console.WriteLine("num2");
        num2=int.Parse(Console.ReadLine());

        product=num1*num2;

        Console.WriteLine("Product of two numbers {0}",product);

    }
}