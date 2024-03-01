using System;
public class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Sunday patient count");
        int sunday=int.Parse(Console.ReadLine());

        Console.WriteLine("Saturday patient Count");
        int saturday=int.Parse(Console.ReadLine());

        Console.WriteLine("Friday patient count");
        int friday=int.Parse(Console.ReadLine());
        
        int sum=sunday+saturday+friday;

        if(sum>=500)
        {
            Console.WriteLine("Danger-Red");
        }
        else if (sum>=250 && sum<500)
        {
            Console.WriteLine("Average=Orange");
        }
        else
         {
            Console.WriteLine("Low Danger-Yellow");
         }

    }
}