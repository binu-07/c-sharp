using System;

public class Program
{
    public static void Main()
    {
        //initiate variable
        double minutes,hours_minutes ;

        //user inputs
        Console.WriteLine("Enter minutes");
        minutes=int.Parse(Console.ReadLine());

        //operation
        hours_minutes=minutes/60;

        //Display the Answer
        Console.WriteLine("hours_minutes is "+hours_minutes);

    }
}