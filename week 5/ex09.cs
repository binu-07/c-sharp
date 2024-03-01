using System;
//Define Structure
public struct PersonName
{
    public string FirstName;
    public string MiddleName;
    public string SurName;

}
public class Program
{
    public static void Main(string[]args)
    {
        PersonName Persone01;

        Console.WriteLine("Enter First Name");
        Persone01.FirstName=Console.ReadLine();

        Console.WriteLine("Enter Middle Name");
        Persone01.MiddleName=Console.ReadLine();

        Console.WriteLine("Enter Sur Name");
        Persone01.SurName=Console.ReadLine();

        Console.WriteLine("Full Name is {0} {1} {2}",Persone01.FirstName,Persone01.MiddleName,Persone01.SurName);
    }

}