using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        //prompt the user to guess the random number until they get it righ
        //validate that the user input a valid # & if not then prompt them again

        static void Main(string[] args)
        {
            int maxvalue = 0;
            int minvalue =0;
            Random rnd = new Random();
            int RandomNumber = rnd.Next(minvalue, maxvalue + 1);

            // || !=
            // generate a random # that the user will define min & max
            Console.WriteLine(" Guess a value between two numbers with a range picked by you!");
            Console.WriteLine("Please, select a minimum number!");
            minvalue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please, select a maximum number!");
            maxvalue = Convert.ToInt32(Console.ReadLine());

            //user input a guess
            int UserGuess = 0;

            do
            {
                Console.WriteLine(" Guess a value between the two numbers with a range picked by you!");
                UserGuess = Convert.ToInt32(Console.ReadLine());

                if (UserGuess > maxvalue || UserGuess < minvalue)
                {
                    Console.WriteLine("Number is not within range, AKA invalid. Keep trying");
                }
            }
            while (UserGuess == RandomNumber);
            Console.WriteLine("You guessed correctly! Gr8 job."); 


            Console.ReadKey();
        }
        
    }
}
