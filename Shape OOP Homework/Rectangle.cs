using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP_Homework
{
    class Rectangle : Quadrilateral
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle (double length, double width, int x=0, int y=0) : base (x,y){
            Length = length;
            Width = width;

            Side1 = Length;
            Side2 = Length;
            Side3 = Width;
            Side4 = Width;

    }
        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }
        
       
        }
    }
