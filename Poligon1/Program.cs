using System;
using System.ComponentModel.Design;

namespace Poligon1
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Select a polygon:Triangle or Quadrangle");
            string poligon = Console.ReadLine();
            if (poligon == "Triangle")
            {
                Console.WriteLine("Select the type of triangle:Equilateral ,Isosceles ,Right ");
                Triangle t = new Triangle(Console.ReadLine());
                if (t.Type == "Equilateral")
                {
                    t.CheckEquilateral();
                }
                else if (t.Type == "Isosceles")
                {
                    t.CheckIsosceles();
                }
                else if (t.Type == "Right")
                {
                    t.CheckRight();
                }
            }
            else if (poligon == "Quadrangle")
            {
                Console.WriteLine("Select the type of quadrangle: Parallelogram, Rectangle, Square, Trapezoid");
                Quadrangle q = new Quadrangle(Console.ReadLine());
                if (q.Type == "Parallelogram")
                {
                    q.CheckParallelogram();
                }
                else if (q.Type == "Rectangle")
                {
                    q.CheckRectangle();
                }
                else if (q.Type == "Square")
                {
                    q.CheckSquare();
                }
                else if (q.Type == "Trapezoid")
                {
                    q.ChekTrapezoid();
                }
            }
            else
            {
                Console.WriteLine("There is no such polygon");
            }

        }
    }
}
