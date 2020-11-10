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
          

             Console.ReadKey();
        }

        static string AnimalType()
        {
            Console.WriteLine(" << Please, enter a type of animal. >>");
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
                else if (response == "snake")
                {
                    Console.WriteLine("hissss hisss");
                }

                else if (response == "dog")
                {
                    Console.WriteLine("Bark woof");
                }
                else
                {
                Console.WriteLine("Please, try a different animal!");
                }

            return response;
            Console.ReadKey();
                
            }

    }
}
