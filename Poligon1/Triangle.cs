using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Poligon1
{
    class Triangle: Poligon, IEquilateral, IIsosceles, IRight
    {

        public Triangle(string type):base(type)
        {

        }

        public override void P(double a ,double b,double c)
        {
            Console.WriteLine(a + b + c); 
        }

        public override void S() { }
        

        public void CheckEquilateral()
        {
            Console.WriteLine("Write the length of the a: ");
            double a= double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the c: ");
            double c= double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the triangle is: "+ a * h / 2);
            Console.WriteLine("The perimeter of the triangle is: ");
            P(a, b, c);
        }
        public void CheckIsosceles()
        {
            Console.WriteLine("Write the length of the a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the h:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the triangle is: ");
            Console.WriteLine(a * h / 2);
            Console.WriteLine("The perimeter of the triangle is: ");
            P(a, b, c);

        }
        
        public void CheckRight()
        {
            Console.WriteLine("Write the length of the a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the triangle is: ");
            Console.WriteLine(a * b/ 2);
            Console.WriteLine("The perimeter of the triangle is: ");
            P(a, b, c);
        }
    }
}
