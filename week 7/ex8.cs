using System;
public class Program
{
    public static void Main(string[] args )
    {
        Console.WriteLine("Enter a number 01");
        int num01=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operator (+ - * / )");
        char operator=char.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number 02");
        int num02=int.Prase(Console.ReadLine());
         
        double result = 0 ;
        switch (operator)
        {
            case "+":
                 result= num01+num02;
                 break;

            case "-":
                 result= num01-num02;
                 break;

            case "*":
                 result= num01*num02;
                 break;
            
            case "/":
                 result= num01/num02;
                 break;    

            default:
                 result=0.0;
                 break;



        }
        Console.WriteLine("Result = {0}",result);
    }
}