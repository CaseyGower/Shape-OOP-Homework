using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP_Homework
{

    struct Position
    {
        int x;
        int y;
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;        
         }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    abstract class Shape
    {
        abstract public double Area { get; }
        public Position Center { get; set; }
        abstract public double Perimeter { get; }

       

        public Shape()
        {
            Center = new Position();
        }

         public Shape (int x, int y):this(new Position (x,y))
        {
        } 

         public Shape (Position p)
        {
            Center = p;
        }
    }
}
