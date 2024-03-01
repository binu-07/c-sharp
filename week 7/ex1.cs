using System;
public class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter the Age");
      int age=int.Parse(Console.ReadLine());

      string answer=(age<=60)?"Not eligible for the vaccination":"Eligible for the vaccination";
      Console.WriteLine("Answer is {0}",answer);
    }
}
