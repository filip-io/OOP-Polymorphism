using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism.Shapes
{
    //Declaration of sub class

    internal class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Sub class constructor
        public Rectangle()
        {
            Length = 74.2;
            Width = 54.3;
        }

        // Declaration of override method Area()
        public override double Area()
        {
            return Length * Width; 
        }
    }
}
