using System;

public class Program
{
    public static void Main(string[] args)
    {
       string name;
       int days=0;
       int Total_hours;

       do
       {
            Console.WriteLine("Enter the student's name");
            name=Console.ReadLine();
            if(name=="END")
                {
                    break;
                }
                Console.WriteLine("Enter the attended for lectures in month");
                days=int.Parse(Console.ReadLine());

                Total_hours=days*3;

                Console.WriteLine("Name {0}",name);
                Console.WriteLine("Total hours={0}",Total_hours);

       }
        while(name!="END");

       

    }
}
