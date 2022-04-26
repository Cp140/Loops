using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int input;
            //Reads low number
            Console.WriteLine("Enter a number.");
            while (!Int32.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Invalid number, try again.");
            Console.WriteLine($"Thanks for {min}!");


            //Reads high number
            Console.WriteLine("Enter a larger number:");
            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out max))
                    Console.WriteLine("Invalid number, try again.");
            
                if (max <= min + 1 )
                    Console.WriteLine("Error number too low!");
            
            
            } while (max <= min + 1);
            Console.WriteLine($"Thanks for {max}!");
                

            //Reads number in between
            Console.WriteLine($"Enter number in between {min} and {max}");
            do
            {


                while (!Int32.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("Invalid number, try again.");


            } while (input <= min-1 || input >= max+1);
            //correct message
            Console.WriteLine($"correct you entered {input} with in range of {min} and {max}");
        }
    }
}
