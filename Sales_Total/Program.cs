using System;
using System.Net.Http.Headers;

namespace Sales_Total
{
    class Program
    {
        //assume sales tax is 8.5%
        const double Sales_Tax = 0.085;
        static void Main(string[] args)
        {
            double Quantity = 0;
            double Price = 0;
            string productname = "Nike Michael Jordan Shoe";

            //item being bought
            Console.WriteLine("What is the product name of the shoe or shoes you are purchasing?");
            productname = Console.ReadLine();
            
            //quantity of item
            Console.WriteLine("How many" + " " + productname + "'s" + " " + "do you want to buy?");
            Quantity = Convert.ToDouble(Console.ReadLine());
            
            //price for the item
            Console.WriteLine("What is the price for each" + " " + productname + "?");
            Price = Convert.ToDouble(Console.ReadLine());

            //calculate total price
            double subtotal = (Quantity * Price);
            double tax = (subtotal * Sales_Tax);
            double total = (subtotal + tax);

            //output all 3 to the user
            Console.WriteLine(" ");
            Console.WriteLine("        " + "Your subtotal for your bill is " + subtotal.ToString("C2") + "!");
            Console.WriteLine("        " + "Your sales tax for your bill is " + tax.ToString("C2") + "!");
            Console.WriteLine("        " + "Your total for your bill is " + total.ToString("C2") + "!");


        }
    }
}
