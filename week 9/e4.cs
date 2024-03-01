sing System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new arr[10];
        int max;
        //user inputs 
        for(int i=1; i<10; i=i+1)

        {
            Console.WriteLine("enter a number ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        {
           for (int j=1 ; j<10 ; j=j+1)
              {
              if(arr[j]>max)
                   {
                       max=arr[j];
                   }
              } 
        }
        Console.WriteLine("Maimum number is = {0}", max);
    }
}
