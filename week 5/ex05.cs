using System;
//Define structuer
public struct Detail
{
   public string  Name;
   public string Number;
   public string Age;

}
public class Program
{
   public static void Main(string[]args)
{
   Detail Customer01;
   
   Console.WriteLine("Enter Customer Name");
   Customer01.Name=Console.ReadLine();

   Console.WriteLine("Enter Customer Mobile Number");
   Customer01.Number=Console.ReadLine();

   Console.WriteLine("Enter Customer Age");
   Customer01.Age=Console.ReadLine();

   Console.WriteLine("Customer Name :{0}\nCustomer Moblie Number :{1} \nCustomer Age :{2}",Customer01.Name,Customer01.Number,Customer01.Age);
}
}




    
 
 