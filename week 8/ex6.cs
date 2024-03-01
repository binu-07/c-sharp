using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num=3;
        while(num<=19)
        {
            Console.WriteLine(num);
            num= num+4;
        }


        int num2=3;
        do 
        {
          Console.WriteLine (num2);
          num2=num2+4; 
        }
        while(num2<=19);

    

        for(int i=3;i<=19;i=i+3)
        {
            Console.WriteLine(i);
        }
    }
}