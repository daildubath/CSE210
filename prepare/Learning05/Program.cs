using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        Circle circle = new Circle("Blue");
        Square square = new Square("Red");
        Rectange rectange = new Rectange("Green");



        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectange);

        foreach (Shape shape in shapes)
        {
            
            System.Console.WriteLine(shape.GetColor());
            System.Console.WriteLine(shape.GetArea());

        }

    }
}