using System;
using System.Runtime.CompilerServices;

namespace Student_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Grace";
            string LastName = "Dennis";
            string StudentID = "8675309";
            double Homework = 0;
            double Participation = 0;
            double Quiz = 0;
            double Midterm = 0;

            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What is your Student ID?");
            StudentID = Console.ReadLine();

            Console.WriteLine("What is your overall % grade for the Homeworks?");
            Homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall % grade for the Participations?");
            Participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall % grade for the Quizzes?");
            Quiz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall % grade for the Midterm?");
            Midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall % grade for the Final?");
            double Final = Convert.ToDouble(Console.ReadLine());
            double final_grade = ((Homework + Participation + Quiz + Midterm + Final) / 500);

            Console.WriteLine(FirstName + " " + LastName + " " + "(" + StudentID + ")," + " " + "your final grade is" + " " + final_grade.ToString("P2"));

        }
    }
}
