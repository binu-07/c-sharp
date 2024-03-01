using System;
public class Program
{
    public static void Main(string[] args)
    {
        int num,sum=0;
        double avg=0;

        for(int i=1;i<=5;i=i+1)
        {
            Console.WriteLine("Enter number");
            num=int.Parse(Console.ReadLine());
            sum=num+sum;
        }
        avg=sum/5;
        Console.WriteLine("Sum {0}",sum);
        Console.WriteLine("Average = {0}",avg);


    }
}