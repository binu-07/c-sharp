using System;
public class Program
{
    public static void Main(string[] args)
    {
        double[] temp = new double[7];
        double sum = 0;

        for(int i=0; i<7 ; i=i+1)
        {
            Console.WriteLine("Enter the tempreture"+ (i+1));
            temp[1]=double.Parse(Console.ReadLine());
            sum = sum +temp[i];

        }
        double average =sum/7;
        Console.WriteLine(" Average tempreture weekly {0}",Math.Round(average,4));
         


    }
}