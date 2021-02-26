using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Enums.Shapes;

namespace Second.Entities.Shapes
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
