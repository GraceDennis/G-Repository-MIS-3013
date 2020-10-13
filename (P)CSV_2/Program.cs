using System;
using System.IO;

namespace _P_CSV_2
{
    class Program
    {
        static void Main(string[] args)
        {//Grace Dennis
            /*output all of the Names of the individual, 
             * as well as the Transaction_Date  
             * Only show the information about the individual 
             * (their name and the transation date) if they used a Visa 
             * AND the sale took place in the United States. 
            */
            string filePath = @"SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            /* Name = 4
             * TransD8 = 0
             * Visa = 3
             * Country = 7
            */
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string TransD8 = pieces[0];
                string name = pieces[4];
                

                if (pieces[3].ToLower() == "visa" && pieces[7].ToLower() == "united states")
                {
                    Console.WriteLine($"{name}, {TransD8}");
                }
            }
            Console.ReadKey();

        }
    }
}
