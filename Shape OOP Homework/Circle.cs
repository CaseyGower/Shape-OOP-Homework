using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP_Homework
{
    class Circle:Shape
    {
        public double Radious { get; set; }
        public double Diameter { get; set; }
        public double Circumference { get; }

        public override double Area
        {
            get
            {
                double area = Math.PI * Math.Pow(Radious, 2);
                return area;
            }
        }

        public override double Perimeter
        {
            get
            {
                return Circumference;
            }
        }

        public Circle(double radius, int x = 0, int y = 0): base(x, y)
        {
            Radious = radius;
            Diameter = 2*(radius);
            Circumference = 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return $" Radius: {Radious}, Diameter: {Diameter}, Circumference : {Circumference }, Center Position: {Center}";
        }
    }
}
