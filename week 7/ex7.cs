using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the bloodGroup");
        string bloodGroup=Console.ReadLine();

        switch (bloodGroup)
        {
            case "A": //bloodgroup=="A
                 Console.WriteLine("Blood Types are A+ and A-");
                 break;

            case "B": 
                 Console.WriteLine("Blood Types are B+ and B-");
                 break; 

            case "AB": 
                 Console.WriteLine("Blood Types are AB+ and AB-");
                 break; 

            case "O": 
                 Console.WriteLine("Blood Types are O and O-");
                 break; 
                    
            default:
                 Console.WriteLine("User enter wrong Blood Group");
                 break;               

        }
    }
}