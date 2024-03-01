using System;
public class Program
{
    public static void Main(string[] args)
    {
        int i,sum=0;

        for(int i=3;i<=12;i=i+1)
        {
            Console.WriteLine(i);
            sum=i+sum;
        }
        Console.WriteLine("Summetion is {0}",sum);
    }
}