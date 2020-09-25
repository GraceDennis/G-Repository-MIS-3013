using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "goodbye";

            if (password == "hello")
            {
                Console.WriteLine("password is correct");
            }

            else { Console.WriteLine("password is incorrect"); Console.ReadLine();}
        } 
        
        
    }
}
