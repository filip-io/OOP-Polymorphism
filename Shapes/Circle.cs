using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism.Shapes
{

    //Declaration of sub class

    internal class Circle : Geometry
    {
        public double Radius { get; set; }


        // Sub class constructor

        public Circle()
        {
            Radius = 8;
        }


        // Declaration of override method Area()

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
