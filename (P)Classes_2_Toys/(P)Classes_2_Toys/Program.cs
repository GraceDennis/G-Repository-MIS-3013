using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P_Classes_2_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToyBox AddToy = new ToyBox();

            Toy one = new Toy();
            one.Manufacturer = "Nintendo";
            one.Name = "Switch Console";
            one.Price = 450.00;


            Console.WriteLine("Toy One is manufactured by " + one.Manufacturer + ". Toy One is named " + one.Name + "Toy One is priced at: " + one.Price);
            Console.WriteLine("Toy One is on aisle: " + one.GetAisle() + ".");
            Console.WriteLine("--------------------------------");

            Toy two = new Toy();
            two.Manufacturer = "Microsoft";
            two.Name = "Xbox";
            two.Price = 499.00;

            Console.WriteLine("Toy Two is manufactured by " + two.Manufacturer + ". Toy One is named " + two.Name + "Toy One is priced at: " + two.Price);
            Console.WriteLine("Toy Two is on aisle: " + two.GetAisle() + ".");
            Console.WriteLine("--------------------------------");


            Console.WriteLine("Would you like to add another toy in the toybox? Yes or no, please.");
            string input = "";
            input = Console.ReadLine();
            input.ToLower();

            if (input == "yes")
            {
                Console.WriteLine("Input which toy you want to add.");
                string ToyList = Console.ReadLine();
                //AddToy.Add(ToyList);
                //
            }
            else
            {
                Console.WriteLine("Thank you! Goodbye.");
            }

            Console.ReadKey();
            Console.WriteLine("press any key to exit");
        }


    }
}
