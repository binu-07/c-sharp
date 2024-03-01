using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {32,85,41,37,12,77};      // int [] num1= new int[6];

        Console.WriteLine("Elements in an array");

        foreach( int number in numbers)                                    // for(int i =0 ; i<6 : i=i+1);
        {                                                                      //   }
            Console.Write(" {0}",number);  //(number +" ")

        }


    }


}
