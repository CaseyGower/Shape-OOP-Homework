using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP_Homework
{
    class Square: Quadrilateral
    {
        public double Side { get; set; }

        public Square (double side, int x=0, int y=0): base(x, y)
        {
            Side1 = side;
            Side2 = side;
            Side3 = side;
            Side4 = side;
            Side = side;

            
        }

        public override double Area
        {
            get
            {
                double area = Math.Pow(Side, 2);
                return area;
            }
        }
    }
}
