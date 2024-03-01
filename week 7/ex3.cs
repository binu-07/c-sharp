using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the age");
        int age=int.Parse(Console.ReadLine());

        string category=(age>=0 && age<=12)?"is Child":(age>=13 && age<=19)?"is Teenager":"is Adult";
        Console.WriteLine("Category {0}",category);

    }

}