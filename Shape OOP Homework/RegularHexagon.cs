using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP_Homework
{
    class RegularHexagon : Shape
    {
        public double Side { get; set; }

        public override double Area
        {
            get
            {
                double area = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(Side, 2);
                return area;
            }
        }

        public override double Perimeter
        {
            get
            {
                return Side*6;
            }
        }

        public RegularHexagon(double side, int x = 0, int y = 0) : base(x, y)
        {
            Side = side;


        }

        public override string ToString()
        {
            return $" Side Lenght: {Side}, Center Position: {Center}";
        }
    }
}
