using System;
//Define enum
enum Medal
{
    USA=39,
    China=38,
    Japan=27
}
public class Program 
{
    public static void Main(string[]args)
    { 
        int MedalUSA=(int)Medal.USA;
        Console.WriteLine("USA{0}",MedalUSA);

        int MedalChina=(int)Medal.China;
        Console.WriteLine("Chaina{0}",MedalChina);

        int MedalJapan=(int)Medal.Japan;
        Console.WriteLine("Japan{0}",MedalJapan);

    }
}