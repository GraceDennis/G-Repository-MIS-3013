using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// start off with that quote !!!!

namespace _P__String_Manipulation
{
    class Program
    {
        const string quote = "Programming today is a race between software engineers strivingto build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(quote);


            Console.WriteLine("please, input a word you want to look for in the sentence above.");
            string change = Console.ReadLine();


            Console.WriteLine("pick a word you want {change} to be *replaced* with");
            string changeTo = Console.ReadLine();
            Console.WriteLine();
            
            bool search = quote.Contains(change);

            string valid_input;
            
            if (search == true)
            {
                valid_input = quote.Replace(change, changeTo);
                Console.WriteLine("validinput");

            }
            else
            {
                Console.WriteLine("sorry, I could not find your word: " + change);
            }
            // double check instructions
            for (int g = change.Length - 1; g >= 0; --g)
            {
                char reverse = change[g];

                Console.Write(reverse);
            }

                Console.ReadKey();

        }
        
        
        
    }
}
