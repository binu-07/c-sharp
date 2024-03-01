using System;

public class Program
{
    public static void Main()
    {
        //initiate variable
        double pie = 3.14159 , radius, area;

        //user input
        Console.Write("Enter radius");
        radius=double.Parse(Console.ReadLine());

        //operation
        area=pie*radius*radius;

        //Display the Answer
        Console.WriteLine("area is"+area);
    }
}