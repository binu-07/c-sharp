using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num=3;

        do
        {
            Console.WriteLine(num);
            num = num+3;
        }
        while(num<=12);
    }
}