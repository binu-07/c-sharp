using System;

public class Program
{
    public static void Main()
    {
       int num1,num2,sum=0;
    
        Console.WriteLine("num1");
        num1=int.Parse(Console.ReadLine());;

        Console.WriteLine("num2");
        num2=int.Parse(Console.ReadLine());

        sum=num1+num2;

        Console.WriteLine("sum is {0}",sum);

    }
}