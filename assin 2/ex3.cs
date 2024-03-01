using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the username");
        string username=Console.ReadLine();

        Console.WriteLine("Enter the password");
        string password=Console.ReadLine();

        string your=(username=="admin" && password=="password123")?"Login successful":"Login fail";
        Console.WriteLine("Your {0}",your);

    }
}