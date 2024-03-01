using System;

public class Program
{
    public static void Main()
    {
        //initiate variable
        double celsius_temp,Fahrenheit_temp;

        //user Inputs
        Console.WriteLine("Enter celsius_temp");
        celsius_temp= double.Parse(Console.ReadLine());

        //Operation
        Fahrenheit_temp=(celsius_temp*9/5)+32;

        //Display the Answer
        Console.WriteLine(Fahrenheit_temp);

    }
}