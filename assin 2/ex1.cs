using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the age ");
        int age=int.Parse(Console.ReadLine());

        string answer=(age>=60)?"Eligibilty for the vaccination":"Not eligibilty for the vaccination";
        Console.WriteLine(" {0}",answer);
    }
}