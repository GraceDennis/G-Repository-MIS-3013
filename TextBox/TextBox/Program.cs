using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox box = new TextBox();
           
            box.BackColor = ConsoleColor.Red;
            box.ForeColor = ConsoleColor.Cyan;
            box.Padding = 21;
            box.Text = "Do you want a cup of coffee?";

            box.DisplayText();
            Console.ReadLine();

            TextBox box2 = new TextBox();
            box2.BackColor = ConsoleColor.DarkGray;
            box2.ForeColor = ConsoleColor.Blue;
            box2.Padding = 21;
            box2.Text = "Yes!";
            box2.DisplayText();
            Console.ReadLine();


            Console.WriteLine(">> Press any key to exit <<");
            Console.ReadLine();
        }
    }
}
