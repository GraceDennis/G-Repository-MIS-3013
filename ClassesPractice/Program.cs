using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            List<string> lastNames = new List<string>();
            List<string> DOB = new List<string>();
            List<string> favfood = new List<string>();
            List<double> accountbalance = new List<double>();

            firstNames.Add("Adam");
            lastNames.Add("Ackerman");
            DOB.Add("11/5/2020");
            favfood.Add("Pizza");
            accountbalance.Add(500);

            firstNames.Add("grace");
            lastNames.Add("dennis");
            DOB.Add("9/10/2020");
            favfood.Add("tacos");
            accountbalance.Add(55500);

            for (int i = 0; i < firstNames.Count; i++)
            {
                Console.WriteLine($"{firstNames[i]} {lastNames[i]} {DOB[i]} likes {favfood[i]} and has {accountbalance[i].ToString("C")}. ");
            }

            //same but use classes now!!!!!!!!
            Person adam = new Person();
            adam.firstName = "Adam";
            adam.lastName = "Ackerman";
            adam.DOB = "11/5/2020";
            adam.favfood = "Pizza";
            adam.accountbalance = 500;

            Person grace = new Person("grace", "dennis", "6/4/2020", "tacos", 55000);
            Console.WriteLine(adam.ToString());
            Console.WriteLine(grace);

            //list of person and added grace and adam
            List<Person> peeps = new List<Person>();
            peeps.Add(grace);
            peeps.Add(adam);


            Console.WriteLine("press any key to exit!");
            Console.ReadKey();
            
        }
    }
}
