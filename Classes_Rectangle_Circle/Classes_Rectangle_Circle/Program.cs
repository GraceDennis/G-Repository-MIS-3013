using System;
using System.Drawing;

namespace Classes_Rectangle_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine($"The area of a circle with {myCircle.Radius} is {myCircle.CalculateArea()}" + $"and a perimeter of {myCircle.CalculatePerimeter()}");
            Console.WriteLine("-----------------------------------------------");

            Circle circle2 = new Circle();
            circle2.Radius = 65647733;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();
            Console.WriteLine($"Area of a circle with a radius of {circle2.Radius} is {areaOfCircle2.ToString("N2")}");
            Console.WriteLine($"Perimeter of a circle with a radius of {circle2.Radius} is {perimeterOfCircle2.ToString("N2")}");
            Console.WriteLine("----------------------------------------------");

            Rectangle rectangle = new Rectangle();
            rectangle.Length = 6;
            rectangle.Width = 15;
            Console.WriteLine($"Area of a rectangle with a length of {rectangle.Length} and width of {rectangle.Width} is {rectangle.CalculateArea().ToString("C2")}");
            Console.WriteLine($"Perimeter of a rectangle with a length of {rectangle.Length} and width of {rectangle.Width} is {rectangle.CalculatePerimeter().ToString("C2")}");
            Console.WriteLine("----------------------------------------------");

            Rectangle rectangle2 = new Rectangle();
            rectangle2.Length = 23;
            rectangle2.Width = 90;
            Console.WriteLine($"Area of a rectangle with a length of {rectangle2.Length} and width of {rectangle2.Width} is {rectangle2.CalculateArea().ToString("C2")}");
            Console.WriteLine($"Perimeter of a rectangle with a length of {rectangle2.Length} and width of {rectangle2.Width} is {rectangle2.CalculatePerimeter().ToString("C2")}");
            Console.WriteLine("----------------------------------------------");


            Console.ReadKey();

        }
    }
}
