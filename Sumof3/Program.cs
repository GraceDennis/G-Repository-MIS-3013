using System;

namespace Participation1_SumOf3Numbers
{
    class Program
   {
        static void Main(string[] args)
        {

            Console.WriteLine("Number of vacation days you want?");
            double days = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(value: "Enter your age in number format");
            double age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give the number of jobs you have had ");
            double jobNumber = Convert.ToDouble(Console.ReadLine());

        /* ADD & PRINT THE SUM with 3<<<<<< decimal places */
            Console.WriteLine("The sum of your three different numbers");
            double sum = days + age + jobNumber;
            Console.WriteLine(sum.ToString("F3")); 

        /* MULTIPLY <<< THE SUM BY A CONST VALUE OF 7.777 */
        /* HINT MAKE CONST VARIABLE DOUBLE */
            const double seven = 7.777;
            double product = sum * seven;

            Console.WriteLine("The sum multiplied by 7.777 equals " + product);
        }


   
    }
}