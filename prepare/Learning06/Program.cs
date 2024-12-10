using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square= new Square();
        square.SetColor("Purple");
        square.SetSide(4);
        


        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Yellow");
        rectangle.SetWidth(4);
        rectangle.SetLength(7);

        Circle circle= new Circle();
        circle.SetColor("Blue");
        circle.SetRadius(4);

        DisplayShapes(square);
        DisplayShapes(rectangle);
        DisplayShapes(circle);
    }
    

        public static void DisplayShapes(Shape shape)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape has the color {color} and the area is {area}. ");

        }
    


    }
