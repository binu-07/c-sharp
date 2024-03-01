using System;
//Define Structure 
public struct Detail
{
    public string Name;
    public int Age;
    public double Height;
}
public class Program
{
    public static void Main(string[]args)
    {
        Detail Customer01;

        Console.Write("Enter the Name");
        Customer01.Name= Console.ReadLine();

        Console.Write("Enter the Age");
        Customer01.Age= int.Parse (Console.ReadLine());

        Console.Write("Enter the Height");
        Customer01.Height= double.Parse(Console.ReadLine());

        Console.Write("New customer is {0}, {1}, {2}m", Customer01.Name,Customer01.Age,Customer01.Height);
    }
}