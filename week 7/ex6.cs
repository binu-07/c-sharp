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
            case 15:
               Console.WriteLine("Number is 10 or 15");
               break;

            case 20:
            case 25:
               Console.WriteLine("Number is 20 or 25");
               break;

            case 30:
            case 35:
               Console.WriteLine("Number is 30 or 35");
               break;

            default:
               Console.WriteLine("Number is not match with 10 or 15,20 or 25,30 or 35");
               break;   


            
        }



    
    }

}