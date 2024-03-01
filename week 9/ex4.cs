using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {32 ,25,85,43,13};

        int max = numbers[0];
        for(int i=1; i<numbers.Length; i=i+1)
        {
            if (numbers[i] >max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("Maimum number is = {0}", max);
    }
}