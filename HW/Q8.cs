using System;

public class Program
{
    public static void Main()
    {
        double celsius_temp,Fahrenheit_temp=0;

        Console.WriteLine("celsius_temp");
        celsius_temp=double.Parse(Console.ReadLine());

        Fahrenheit_temp=(celsius_temp*9/5)+32;

        Console.WriteLine("Convert temp {0}",Fahrenheit_temp);
    }

}