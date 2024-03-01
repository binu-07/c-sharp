using System;
public class Program
{
    public static void Main(string[] args)
    {
        string name;
        int days;
        int total_hours;
        
        do
        {
        Console.WriteLine("Enter the name");
        name=Console.ReadLine();

        Console.WriteLine("enter days attend for the lectures in a month");
        days=int.Parse(Console.ReadLine());

        total_hours=days*3;
        Console.WriteLine("Name is {0}",name);
        Console.WriteLine("Total_hours {0}",total_hours);
        }
        while(name!="END");

        
    }
}