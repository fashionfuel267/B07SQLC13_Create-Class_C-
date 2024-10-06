using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07SQLC13_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of radius");
            int r=int.Parse( Console.ReadLine());
            //Instance/object create
            Circle circle = new Circle(r);
            Console.WriteLine("Enter the value of 2nd radius");
            int r1 = int.Parse(Console.ReadLine());
            Circle circle1 = new Circle(r1);
            double a = circle.Area();
            double b = circle1.Area();
            Console.WriteLine($"radius {r}'s area is {a}");
            Console.WriteLine($"radius {r1}'s circles area is {b}");
            Console.ReadKey();
        }
    }
    class Circle
    {
        //field
        int radius;

        //Default Constructor
       public Circle(int r)
        {
            this.radius = r;
        }

       public double Area()
        {
            return Math.PI * radius *radius;
        }

    }

}
