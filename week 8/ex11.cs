using System;

public class Program
{
    public static void Main(string[] args)
    {
        int i,sum=0;

    for(i=4;i<=11;i=i+1)
    {
        Console.WriteLine(i);
    sum=i+sum;
    }  

    Console.WriteLine("Summation = {0}",sum);
    }

}