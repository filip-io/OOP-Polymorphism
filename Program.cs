

// Filip Nilsson NET23


using OOP_Polymorphism.Shapes;

namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry Circle = new Circle(); 
            Console.WriteLine($"The area of the circle is: {Math.Round(Circle.Area(), 2)}");

            Geometry Square = new Square();
            Console.WriteLine($"The area of the square is: {Math.Round(Square.Area(), 2)}"); 

            Geometry Rectangle = new Rectangle();
            Console.WriteLine($"The area of the rectangle is: {Math.Round(Rectangle.Area(), 2)}");

            Geometry Parallelogram = new Parallelogram();
            Console.WriteLine($"The area of the parallelogram is: {Math.Round(Parallelogram.Area(), 2)}");

            Geometry Ellipse = new Ellipse();
            Console.WriteLine($"The area of the ellipse is: {Math.Round(Ellipse.Area(), 2)}");
        }
    }
}