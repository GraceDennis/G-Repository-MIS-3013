using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        { //random number between 1 and 100 
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            // If the number they provided to you is divisible by 3 & 5, then you should output the word 'Fizz'.

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                Console.WriteLine("FizzBuzz"); ;
            }
            // If the number is divisible by 5, then you should output the word 'Buzz'
            else if (number % 5 == 0) ;
            if (number % 3 == 0) ;

            {
                Console.WriteLine("Buzz");
                Console.WriteLine("Fizz");
            }

            //If the number is NOT divisible by either, just output the number back out
            if (number % 3 != 0 && number % 5 != 0) ;
            {
                Console.WriteLine(number);
            }
        }
    }
}
