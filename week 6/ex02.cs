using System;

public class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter the villeger's age");
        int age=int.Parse(Console.ReadLine());

        if (age >=60)
        {
            Console.WriteLine("Eligibled for the Vaccination");
        }
        else
        {
            Console.WriteLine("Not Eligibled for the Vaccination");
        }
        }
    }
  

  // string age (age>= 60)? "Eligible for vaccinate": "Not eligible for vaccinate"