using System;
//Define Enum
enum Status
{
    Pass,
    Fail,
    Merit
}
public class Program
{
    public static void Main(string[]args)
    {
        Status Pass=Status.Pass;
        Console.WriteLine("Status {0}",Pass);
        
        Status Fail=Status.Fail;
        Console.WriteLine("Status{0}",Fail);

        Status Merit=Status.Merit;
        Console.WriteLine("Status{0}",Merit);
    }
}