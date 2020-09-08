using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
       
            Console.WriteLine(number);
        }
    }
}
