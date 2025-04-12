using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square(12,"blue");
        Rectangle r1 = new Rectangle(7,14,"red");
        Circle c1 = new Circle(47,"white");

        List<Shape> shapes = new List<Shape>{s1,r1,c1};
        
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape's area is {area}");
        }

    }
}