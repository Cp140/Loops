using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            //Reads low number
            Console.WriteLine("enter a number");
            while (!Int32.TryParse(Console.ReadLine(), out number1))
                Console.WriteLine("Invalid number, try again.");
            Console.WriteLine($"Thanks for {number1}!");
            //Reads high number
            Console.WriteLine("enter a larger number:");
            while (!Int32.TryParse(Console.ReadLine(), out number2))
                Console.WriteLine("Invalid number, try again.");
            Console.WriteLine($"Thanks for {number2}!");
            //Reads number in between
            Console.WriteLine($"Enter number in between {number1} and {number2}");
            do while
            


            while (number2 )
            
            
            
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid integer, try again.");
                Console.WriteLine($"Thanks for {number}!");
            }
        }
    }
}
