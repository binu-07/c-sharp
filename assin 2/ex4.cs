using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of month");
        int month=int.Parse(Console.ReadLine());

        string answer=(month==1)?"January":(month==2)?"February":(month==3)?"March":(month==4)?"April":(month==5)?"May":(month==6)?"June":(month==7)?"July":(month==8)?"Augest":(month==9)?"September":(month==10)?"Octomber":(month==11)?"November":(month==12)?"December":"Error";
        Console.WriteLine("Month is {0}",answer);

    }
}
