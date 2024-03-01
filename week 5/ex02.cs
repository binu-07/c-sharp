using System;
//Define enum
enum Medle
{
    USA=39,
    China=38,
    Japan=27
}

public class Program 
{
    public static void Main()
    {
     //creating object variables
     int medleUSA=(int)Medle.USA;
     int medleChina=(int)Medle.China;
     int medleJapan=(int)Medle.Japan;

     //Display
     Console.WriteLine("Medle Count are \nUSA ={0}\nChina={1}\nJapan ={2}", medleUSA ,medleChina,medleJapan);
    }
}