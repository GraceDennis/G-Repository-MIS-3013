using System;
using System.Collections.Generic;

namespace _P_Collections_Min_Max_Avg
{
    class Program
    {

        //Ask the user to enter all of their exam grades. 
        //Once they are done, calculate the minimum score, the maximum 
        //score and the average score for all of their scores.  
        // Perform this using at least 2 Loops (can be the same type of 
        //loop) and not any built in functions.
        // EXTRA: Calculate the Mode of the exam scores***
        static void Main(string[] args)
        {
            List<double> examgrades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("Please enter your first exam grade. >>");
                double examgrade = Convert.ToDouble(Console.ReadLine());

                examgrades.Add(examgrade);

                Console.WriteLine("Please enter your second exam grade. >>");
                answer = Console.ReadLine();
                
            } 
            while (answer.ToLower() == "yes");

           
            double max;
            double average;
            double min;

            foreach (var examgrade in examgrades)
            {
                if (examgrade < examgrades[0])
                    if (examgrade <= min)
                    {
                        min = examgrade;

                        Console.WriteLine($"Your minimum grade is {min}.");
                    }
                do
                {
                    if (examgrade > examgrades[0])
                    {
                        max = examgrade;
                        Console.WriteLine($"Your maximum grade is {max}.");
                    }
                    else if (examgrade == examgrades[0])
                    {
                        average = examgrade;
                        Console.WriteLine($"Your average grade is {average}.");
                    }

                } while (true);
            }
            Console.ReadKey();
        }
    }
}