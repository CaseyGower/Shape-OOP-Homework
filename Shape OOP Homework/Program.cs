using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP_Homework
{
    class Program
    {
        static int NumberOfIncorrectChecks = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle: ");
            TestTriangle();

            Console.WriteLine();

            Console.WriteLine($"Number of incorrect checks: {NumberOfIncorrectChecks}");
            Console.WriteLine();

            Console.WriteLine("Rectangle: ");
            TestRectangle();
            Console.WriteLine();

            Console.WriteLine("Square: ");
            TestSquare();
            Console.WriteLine();

            Console.WriteLine("Trapazoid: ");
            TestTrapazoid();
            Console.WriteLine();

            Console.WriteLine("Circle: ");
            TestCircle();
            Console.WriteLine();

            Console.WriteLine("Regular Hexagon: ");
            TestHexagon();

            Console.ReadKey();
        }

        static void TestTriangle()
        {
            //Test every nook and cranny 
            //print out responses 

            Triangle t = new Triangle(3,4,5,0,5);
            Console.WriteLine(t);
            Console.WriteLine("Area: " + t.Area);
            Check(t.Area, 6);
            Console.WriteLine("Perimeter: " + t.Perimeter);
            Check(t.Perimeter, 12);

            Console.WriteLine();

            Triangle t2 = new Triangle(4, 5, 6);
            Console.WriteLine(t2);
            Console.WriteLine("Area: " + t2.Area);
            Check(t2.Area, 9.9215);
            Console.WriteLine("Perimeter: " + t2.Perimeter);
            Check(t2.Perimeter, 15);
            
        }

        static void Check (double actual, double expected)
        {
            if (Math.Abs(actual - expected) > 0.0001)
            {
                NumberOfIncorrectChecks++;
            }

           
        }

        static void TestRectangle()
        {
            Rectangle r = new Rectangle(3, 4);
            Console.WriteLine(r);
            Console.WriteLine(r.Area);
            Console.WriteLine(r.Perimeter);
            Console.WriteLine();
        }

        static void TestSquare()
        {
            Square s = new Square(3);
            Console.WriteLine(s);
            Console.WriteLine(s.Area);
            Console.WriteLine(s.Perimeter);
            Console.WriteLine();
        }

        static void TestTrapazoid()
        {
            IsoscelesTrapezoid r = new IsoscelesTrapezoid(3, 4, 2);
            Console.WriteLine(r);
            Console.WriteLine(r.Area);
            Console.WriteLine(r.Perimeter);
            Console.WriteLine();
        }

        static void TestCircle()
        {
            Circle c = new Circle(3);
            Console.WriteLine(c);
            Console.WriteLine(c.Area);
            Console.WriteLine(c.Perimeter);
            Console.WriteLine();
        }

        static void TestHexagon()
        {
            RegularHexagon h = new RegularHexagon(2);
            Console.WriteLine(h);
            Console.WriteLine(h.Area);
            Console.WriteLine(h.Perimeter);
        }

    }
}
