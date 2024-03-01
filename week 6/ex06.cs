using System;
public class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter a mark");
        int mark=int.Parse(Console.ReadLine());

        if(mark>=75 && mark<=100)
        {
            Console.WriteLine("Your grade is A");
        }
        else if(mark<=74 && mark>=60)
        {
            Console.WriteLine("Your grade is B");
        }
        else if(mark<=59 && mark>=45)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (mark<=30 && mark>=44)
        {
            Console.WriteLine("Your grade is D");
        }
        else 
        {
            Console.WriteLine("Your grade is F");
        }
        
    }
}