using System;
public class Program
{
    public static void Main(string[] args)
    {
        //check the number as 10,20,30. If not match output as "Not match with 10,20,30"

        //User input
        Console.WriteLine("Enter a number");
        int num=int.Parse(Console.ReadLine());

        //switch case
        switch (num)
        {
            case 10://num==10 <this is a exsample
               Console.WriteLine("Number is 10");
               break;

            case 20:
               Console.WriteLine("Number is 20");
               break;

            case 30:
               Console.WriteLine("Number is 30");
               break;

            default:
               Console.WriteLine("Number is not match with 10,20,30");
               break;   


            
        }



    
    }

}