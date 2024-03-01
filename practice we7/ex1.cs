using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the age");
        int age=int.Parse(Console.ReadLine());

        string answer=(age>=60)?"Eligible for vaccination":"Not eligible for vaccination";
        Console.WriteLine("Anser is {0}",answer);

    }
}