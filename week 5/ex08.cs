using System;
//Define enum
enum Patient
{
    Sunday=2500,
    Saturday=2100,
    Friday=2350
}
public class Program
{
   public static void Main(string[]args)
   {
    int PatientSunday=(int)Patient.Sunday;
    Console.WriteLine("Patient count on Sunday = {0}",PatientSunday);

    int PatientSaturday=(int)Patient.Saturday;
    Console.WriteLine("Patient count on Saturday = {0}",PatientSaturday);

    int PatientFriday=(int)Patient.Friday;
    Console.WriteLine("Patient count on Friday = {0}",PatientFriday);
   }
}