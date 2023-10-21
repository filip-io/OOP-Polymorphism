using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism.Shapes
{

    //Declaration of sub class

    internal class Square : Geometry
    {
        public double Side { get; set; }


        // Sub class constructor

        public Square()
        {
            Side = 66;
        }


        // Declaration of override method Area()

        public override double Area()
        {
            return Side * Side;
        }
    }
}
