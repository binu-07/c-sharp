using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1");
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operator (+ ,-,*,/)");
        char operators= char.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number 2");
        int num2=int.Parse(Console.ReadLine());

        double result=0;
        switch(operators)
        {
            case '+':
                result=num1+num2;
                break;

            case "-":
                result=num1-num2;
                break;

            case "*":
                result=num1*num2;
                break;

            case "/":
                result=num1/num2;
                break;

            default:
                result=0.0;
                break;
        }

        

    }
}