using System;
using System.Collections.Generic;
using System.Linq;

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

                Console.WriteLine("Thank you. Now, enter your second exam grade. >>");
                answer = Console.ReadLine();

            }
            while (answer.ToLower() == "yes");

            double max = examgrades[0];
            double totalgrades = 0;
            double min = examgrades[0];
            double average = 0;
            
            for (int i = 0; i < examgrades.Count; i++)
            {
                double examgrade = examgrades[i];

                if (examgrade < max) 
                {
                    max = examgrade;
                }
                if (examgrade > min)
                {
                    min = examgrade;
                }
                //gradeSum = gradeSum + examGrades[i];   
                totalgrades += examgrades[i];
            }
            average = examgrades.Sum() / examgrades.Count();



            Console.WriteLine($"{max} is the lowest exam grade. >>");
            Console.WriteLine($"{min} is the highest exam grade. >>");
            Console.WriteLine($"{average} is the average exam grade. >>");
            Console.ReadKey();
        }

    }
}
//can't figure out foreach way
//foreach (var examgrade in examgrades)
//    if (examgrade < examgrades[0])
//{
//    min = examgrade;

//    Console.WriteLine($"Your minimum grade is {min}.");
//  }