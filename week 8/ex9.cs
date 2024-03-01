using System;

public class Program
{
public static void Main(string[] args)
{
 int row=4;
 int i=1;
 while(i<=row)
 {
    int j=1;
    while(j<=i)
    {
        Console.Write(j+"");
        j=j+1;
    }
    i=i+1;
    Console.WriteLine();
 }
}
}