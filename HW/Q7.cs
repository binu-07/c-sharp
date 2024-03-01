using System;

public class Program
{
    public static void Main()
    {
        int num1,num2,Remainder=0;

        Console.WriteLine("num1");
        num1=int.Parse(Console.ReadLine());

        Console.WriteLine("num2");
        num2=int.Parse(Console.ReadLine());

        Remainder=num1%num2;
        
        Console.WriteLine("Remainder is {0}",Remainder);

    }
}