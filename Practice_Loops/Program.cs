using System;

namespace Practice_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("enter an integer:");

              int myInt = Convert.ToInt32(Console.ReadLine());

              bool isLessThan10 = myInt < 10;
              bool isBetween0and5 = (0 <= myInt) && (myInt <= 5);

              Console.WriteLine($"Integer is less than 10? {isLessThan10}");
              Console.WriteLine($"Integer between 0 and 5? {isBetween0and5}");
              Console.WriteLine($"Exactly one of the above is true?" + $"{isLessThan10 ^ isBetween0and5}");
            */

            /* double balance, interestRate, targetBalance;
             Console.WriteLine("what is ur current balance?");
             balance = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("what is ur current annual interest rate in %?");
             interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
             Console.WriteLine("what balance would you like to have?");
             targetBalance = Convert.ToDouble(Console.ReadLine());
             int totalyears = 0;
             do
             {
                 balance += interestRate;
                 ++totalyears;
             } while (balance < targetBalance);
             Console.WriteLine($"in {totalyears} year{(totalyears == 1 ? "" : "s")} " + $"you'll have a balance of {balance}.");
            */
            double number2 = 0;
            Console.WriteLine("Please enter a number");
            number2 = Convert.ToDouble(Console.ReadLine());

            while (number2 == 3)
            {
                Console.WriteLine("Congratulations!!");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
