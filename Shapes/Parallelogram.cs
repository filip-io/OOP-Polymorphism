using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism.Shapes
{

    //Declaration of sub class

    internal class Parallelogram : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }


        // Sub class constructor

        public Parallelogram()
        {
            Base = 77.8;
            Height = 46.3;
        }


        // Declaration of override method Area()

        public override double Area()
        {
            return Base * Height;
        }
    }
}
