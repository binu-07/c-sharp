using System;

public class Program
{
    public static void Main(string[] args)
    {
        string correctP="12345";
        string password;

        do
        {
            Console.WriteLine("Enter the password");
            password=Console.ReadLine();
        }
        while(password !=correctP);

        Console.WriteLine("Login successfully");
    }
}