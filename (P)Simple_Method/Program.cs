using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P_Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string Animal = AnimalType();
            string response = Speak(Animal);
            Console.WriteLine(response); 

             Console.ReadKey();
        }

        static string AnimalType()
        {
            Console.WriteLine(" << Enter an animal type >>");
            string AnimalType = Console.ReadLine();

            return AnimalType;
        }

        static string Speak(string AnimalType)
            {
            string response = AnimalType;

                if (response == "monkey")
                {
                    Console.WriteLine("OO OO ah ah");
                }
                else if (response == "goat")
                {

                    Console.WriteLine("hee haw bahhhh");
                }
                else 
                {
                    Console.WriteLine("Bark woof");
                }

            return response;
            Console.ReadKey();
                
            }

    }
}
