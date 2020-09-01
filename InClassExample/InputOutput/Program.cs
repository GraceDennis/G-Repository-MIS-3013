/* 
 * Collab with class
*/

using System;

namespace InputOutput
{
    class Program
    {
        const string CLASS_NAME = "MIS 3013";

       static void Main(string[] args)
        {
            //string firstName, lastName;
            string firstName = "Grace";
            string lastName = "Dennis";

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name >>");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your GPA? >>");
            string gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);

            Console.WriteLine(firstName + " " + lastName + " is teaching " + CLASS_NAME + " with a GPA of " + gpa.ToString("N2")); 
        }
    }
}
