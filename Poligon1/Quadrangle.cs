using Poligon1.TypeQuadrilateral;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poligon1
{
    class Quadrangle:Poligon, IParallelogram, IRectangle, ISquare
    {
        public Quadrangle(string type):base (type)
        {

        }

        public override void P(double a, double b, double c) { }


        public override void S() { }

        public void CheckParallelogram()
        {
            Console.WriteLine("Write the length of the a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the d:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the h:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the parallelogram is: " + a*h );
            Console.WriteLine("The perimeter of the parallelogram is: " + (a+b+c+d));

        }

        public void CheckRectangle()
        {
            Console.WriteLine("Write the length of the a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the d:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is: " + a * b);
            Console.WriteLine("The perimeter of the rectangle is: " + (a + b + c + d));
        }

        public void CheckSquare()
        {
            Console.WriteLine("Write the length of the a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the d:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the square is: " + a * a);
            Console.WriteLine("The perimeter of the square is: " + (a + b + c + d));
        }
        public void ChekTrapezoid() 
        {
            Console.WriteLine("Write the length of the a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the d:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the h:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is: " + ((a +c)*h)/2 );
            Console.WriteLine("The perimeter of the trapezoid is: " + (a + b + c + d));
        }



    }
}
