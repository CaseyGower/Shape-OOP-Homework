using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP_Homework
{
    class IsoscelesTrapezoid : Quadrilateral
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Altitude { get; set; }

        public IsoscelesTrapezoid(double base1, double base2, double altitude, int x = 0, int y = 0): base(x, y)
        {
            Base1 = base1;
            Base2 = base2;
            Altitude = altitude;
        }

        public override double Area
        {
            get
            {
                double area = .5 * (Base1 + Base2) * Altitude;
                return area;
            }
        }

        public override double Perimeter
        {
            get
            {
                double perimeter = 0;

                double basesSubtracted = Base1 - Base2;
                double basesSquared = Math.Pow(basesSubtracted, 2);
                double altSquared = Math.Pow(Altitude, 2);
                double totalUnderSqrt = altSquared + basesSquared * (1 / 4);

                double thirdSide = Math.Sqrt(totalUnderSqrt);

                perimeter = Base1 + Base2 + 2 * thirdSide;

                return perimeter;
            }

        }

        public override string ToString()
        {

            return $"Base 1: {Base1}, Base 2: {Base2}, Altitude: {Altitude}, Center Position: {Center}";
        }
    }
}
