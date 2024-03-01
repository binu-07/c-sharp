using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the username");
        string username=Console.ReadLine();

        Console.WriteLine("Enter the password");
        string password=(Console.ReadLine());


        string Your=(username=="admin" && password=="password123")?"Login Successfull":"Login Fail";
        Console.WriteLine("Your {0}",Your);
    }

}