using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the oder number");
        int num=int.Parse(Console.ReadLine());

        switch(num)
        {
            case 1:
            Console.WriteLine("Sri Lankan Special");
            break;

            case 2:
            Console.WriteLine("Fride Rice");
            break;

            case 3:
            Console.WriteLine("Noodles");
            break;

            case 4:
            Console.WriteLine("Pasta");
            break;

            case 5:
            Console.WriteLine("Koththu");
            break;

            default:
            Console.WriteLine("Wrong Code input");
            break;
        }
    }
}