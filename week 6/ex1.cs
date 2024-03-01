using System;
public class Program
{
    public static void Main(String[]args)
    {
        char letter;
        Console.WriteLine("Enter a letter");
        letter=Convert.ToChar(Console.ReadLine());

        //Check the vowel = a,e,i,o,u
        if(letter =='a'|| letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.WriteLine("{0} is a vowel",letter);
        }
        else
        {
            Console.WriteLine("{0} is Not a vowel",letter);
        
        }
                
        


    }
}