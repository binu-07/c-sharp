using System;
public class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine(" Enter a Number");
        int num= int.Parse(Console.ReadLine());

        if(num>0)
        {
            Console.WriteLine("is Positive");
        }
        else
        {
            Console.WriteLine("is Negative");

        }
    }



}