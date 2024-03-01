using System;
public class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter a Number");
        int num=int.Parse(Console.ReadLine());

        if(num%2 ==0)
        {
            Console.WriteLine("is Even Number");
        }
        else
        {
            Console.WriteLine("is Odd Number");
        }
    
            
        
    }
}