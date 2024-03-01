using System;

public class Program
{
public static void Main(string[] args)
{
    int num,sum=0;
    double avg;

   for(int i=1;i<=5;i=i+1)
   {
    Console.WriteLine("Enter the number");
    num=int.Parse(Console.ReadLine());
    
    sum = num+sum;
    
   }
     avg= sum/5;
    Console.WriteLine("sum = {0}",sum);
    Console.WriteLine("avg = {0} ",avg);
   
}
}