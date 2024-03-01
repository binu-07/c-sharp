using System;
//Define Structure
public struct Detail
{
    public string Name;
    public int Age;
    public double Height;
}
public class Program
{
    public static void Main(string[]args)
    {

        Detail Persone01;

        Console.WriteLine("Enter the Name");
        Persone01.Name=Console.ReadLine();

        Console.WriteLine("Persone detail" {0}", Persone01.Name);

    }
}