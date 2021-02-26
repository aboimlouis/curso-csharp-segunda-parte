using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Enums.Shapes;

namespace Second.Entities.Shapes
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Color: ");
            sb.Append(Color.ToString());
            sb.Append(" Area: ");
            sb.Append(Area().ToString("F2"));
            return sb.ToString();
        }
    }
}
