using System;
public class Program
{
    public static void Main(string[]args)
      
{
        Console.WriteLine("Enter the mark01");
        int mark01=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter tha mark02");
        int mark02=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the mark03");
        int mark03=int.Parse(Console.ReadLine());

        int Average =(mark01+mark02+mark03)/3;

        if(Average>=50)
        {
            Console.WriteLine("Average is grater than or equal to 50");
        }
        else
        {
            Console.WriteLine("Average is not grater than 50");
        }
    }
}