using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num=int.Parse(Console.ReadLine());

        string answer=(num%2==0)?"Even number":"Odd number";
        Console.WriteLine("Number is {0}",answer);
    }
}