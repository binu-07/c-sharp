using System;
public class Program
{
    public static void Main(string[] args)
    {
        string correctp ="1234";
        string password;

        do
        {
            Console.WriteLine("Enter the password");
            password=Console.ReadLine();
        }
        while(password!=correctp);

        Console.WriteLine("Loging sucessful",password);
    }
}