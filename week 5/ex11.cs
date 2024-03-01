using System;
//Define enum
enum season
{
    Spring,
    Summer,
    Fall,
    Winter,
}
public class Program
{
    public static void Main(string[]args)
    {
        season seasonSpring=season.Spring;
        Console.WriteLine("season is {0}", seasonSpring);

        season seasonSummer=season.Summer;
        Console.WriteLine("season is {0}",seasonSummer);

        season seasonFall=season.Fall;
        Console.WriteLine("season is  {0}",seasonFall);

        season seasonWinter=season.Winter;
        Console.WriteLine("season is {0}",seasonWinter);
    }
}
