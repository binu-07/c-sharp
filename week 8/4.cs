using System;
public class Program
{
    public static void Main(string[] args)
    {
       double[,] NumArray={{3.5,4.8,1.7},{5.2,6.9,3.6}};
       
       Console.WriteLine(NumArray.GetLength(0));
       Console.WriteLine(NumArray.GetLength(1));
       Console.WriteLine(NumArray.Length);
    }    
}