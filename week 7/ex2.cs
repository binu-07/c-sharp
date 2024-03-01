using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num=int.Parse(Console.ReadLine());

        string number=(num%2==0)?"is Even":"is Odd";
        Console.WriteLine("Number {0}",number);
    }
}