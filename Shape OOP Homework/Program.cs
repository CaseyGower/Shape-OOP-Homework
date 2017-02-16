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
            TestTriangle();

            Console.WriteLine();

            Console.WriteLine($"Number of incorrect checks: {NumberOfIncorrectChecks}");

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
    }
}
