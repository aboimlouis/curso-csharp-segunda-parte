using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Enums.Shapes;

namespace Second.Entities.Shapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return (Radius * Radius) * 3.14;
        }
    }
}
