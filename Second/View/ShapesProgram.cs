using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Second.Entities.Shapes;
using Second.Entities.Enums.Shapes;

namespace Second.View
{
    class ShapesProgram
    {
        public static void Display()
        {
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                string shapeType = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shapeType == "r")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color,width, height));

                }
                else if (shapeType == "c")
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                }
                else
                {
                    Console.WriteLine("No shape like that");
                }
            }

            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
