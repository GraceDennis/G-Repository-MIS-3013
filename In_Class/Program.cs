using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\grace\Downloads\84-0 (1).txt";

            string[] linesOfFile = File.ReadAllLines(filePath);
            int i = 0;
            foreach (var line in linesOfFile)
            {
                string[] pieces = line.Split(' ');
                if (i % 15 == 0 && i != 0)
                {
                    Console.ReadKey();
                }
                Console.ReadKey();
            }

        }

    }

}