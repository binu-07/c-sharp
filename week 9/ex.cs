using System;

public class Program
{
    public static void Main(string[] args)
    {
        //create an arry 
        int[] oneD = new int[4] {7,2,4,6};
        int[,] twoD = new int [2,3] {{5,2,1} , {7,9,4}};


        //check the array Bounds

        Console.WriteLine("1D - Legnth = " + oneD.Legnth(0));
        Console.WriteLine("1D - GetLegnth (0) ="+ oneD.GetLegnth(0));

        Console.WriteLine("2D - Legnth = "+ twoD.Legnth(0));
        Console.WriteLine("2D - GetLegnth(0) =" +twoD.GetLegnth(0));
        Console.WriteLine("2D - GetLegnth(1)" +twoD.GetLegnth(1));

        Console.WriteLine("1D - Rank = "+ oneD.Rank);

         //create an arry 
        int[] oneD = new int[4] {7,2,4,6};
        int[,] twoD = new int [2,3] {{5,2,1} , {7,9,4}};


        //Array Methods
        //sort
        Array.sort(oneD);
        Array.Revers(oneD);

        //Display
        foreach (int k in oneD)
        {
            Console.WriteLine(k + " ");
        }

        //clear
        Array.clear(oneD,0,2); // (oneD, 0 , oneD.Legnth);

        //Display
        foreach (int k in oneD)
        {
            Console.WriteLine(k + " ");
        }


        //indexOF function
        Console.WriteLine(Array.IndexOF(oneD,6));

    









        
    }
}
