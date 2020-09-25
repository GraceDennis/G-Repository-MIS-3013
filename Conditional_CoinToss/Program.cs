using System;

namespace Participation_HeadsTails
{
    class Program
    {
        const string DEVELOPER = "Grace Dennis";
        static void Main(string[] args)
        {
            Console.WriteLine("Heads or Tails? Capitalize the first letter only, please.");
            string response = Console.ReadLine();

            Random rnd = new Random();
            int num = rnd.Next(0, 3);

            if (num == 1)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }
            if ((num == 1) && (response == "Heads"))
            {
                Console.WriteLine("*WINNER*! Congrats!");
            }
            else if ((num == 2) && (response == "Tails"))
            {
                Console.WriteLine("*WINNER*! Congrats!");
            }
            else
            {
                Console.WriteLine("YOU HAVE *LOST*! Better luck next time.");
            }
            Console.ReadLine();

            Console.WriteLine(DEVELOPER);
        }
    }
}