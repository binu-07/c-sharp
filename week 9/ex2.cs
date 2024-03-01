using System;
public class Program
{
    public static void Main(string[] args)
    {
        string[] friends = new string[5];

        for( int i=0;i<5;i=i+1)
        {
            Console.WriteLine("Enter the name :");
            friends[i]=Console.ReadLine();
        }

        Console.WriteLine(" Friend list");

        foreach (string friend in friends)
        {
            Console.WriteLine(" {0}",friend);
        }

    }
}