using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Practice_Cont
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is ch 4 example 5
            double balance, interestRate, targetBalance;
            Console.WriteLine("what is ur current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is ur current annual interest rate?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.00;
            Console.WriteLine("what balance would you like to have?");
            //part 1
            targetBalance = Convert.ToDouble(Console.ReadLine());

            //part 2
            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} " +
                $"you'll have a balance of {balance}.");

            if (totalYears == 0)
            {
                Console.WriteLine("tbh, u did not need a calculator");
            } Console.ReadKey();

        }
    }
}

