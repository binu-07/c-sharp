using System;

public class Program
{
    public static void Main()
    {
        //initiate variable
        double num1, num2,num3,average;

        //user input
        Console.WriteLine("Enter num1");
        num1=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2");
        num2=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter num3");
        num3=double.Parse(Console.ReadLine());

        //operation
        average=num1+num2+num3/3;

        //Display the Answer
        Console.WriteLine("average is"+average);

    }
}