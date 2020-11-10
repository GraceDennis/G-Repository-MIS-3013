using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Rectangle_Circle
{
    class Rectangle
    {
        public double Width { get; set; }

        public double Length { get; set; }

        public Rectangle()
        {
            Width = 0;
            Length = 0;
        }

        public double CalculateArea()
        {
            return Width * Length;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Length);
        }
    }
}
