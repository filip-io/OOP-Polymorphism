using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism.Shapes
{

    //Declaration of sub class

    internal class Ellipse : Geometry
    {
        public double majorAxis { get; set; }
        public double minorAxis { get; set; }


        // Sub class constructor

        public Ellipse()
        {
            majorAxis = 88.7;
            minorAxis = 56.4;
        }


        // Declaration of override method Area()

        public override double Area()
        {
            return Math.PI * majorAxis * minorAxis;
        }
    }
}
